using Microsoft.AspNetCore.Mvc;
using Moq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Nop.Core;
using Nop.Core.Caching;
using Nop.Core.Domain.Discounts;
using Nop.Core.Domain.Orders;
using Nop.Core.Domain.Security;
using Nop.Data;
using Nop.Plugin.DiscountRules.CustomerRoles.Controllers;
using Nop.Plugin.DiscountRules.CustomerRoles.Models;
using Nop.Services.Caching;
using Nop.Services.Catalog;
using Nop.Services.Configuration;
using Nop.Services.Customers;
using Nop.Services.Discounts;
using Nop.Services.Events;
using Nop.Services.Localization;
using Nop.Services.Security;
using Nop.Services.Tests;
using Nop.Tests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nop.Plugin.DiscountRules.CustomerRoles.Tests
{
    [TestFixture]
    public class DiscountRulesCustomerRolesControllerTests : ServiceTest
    {
        private IDiscountPluginManager _discountPluginManager;
        private IDiscountService _discountService;
        private readonly Mock<ILocalizationService> _localizationService = new Mock<ILocalizationService>();
        private readonly Mock<IEventPublisher> _eventPublisher = new Mock<IEventPublisher>();
        private readonly Mock<ICustomerService> _customerService = new Mock<ICustomerService>();
        private readonly Mock<IProductService> _productService = new Mock<IProductService>();
        private readonly Mock<ISettingService> _settingService = new Mock<ISettingService>();
        private readonly Mock<IPermissionService> _permissionService = new Mock<IPermissionService>();
        private readonly Mock<IRepository<Discount>> _discountRepo = new Mock<IRepository<Discount>>();
        private readonly Mock<IRepository<DiscountRequirement>> _discountRequirementRepo = new Mock<IRepository<DiscountRequirement>>();
        private readonly Mock<IRepository<DiscountUsageHistory>> _discountUsageHistoryRepo = new Mock<IRepository<DiscountUsageHistory>>();
        private readonly Mock<IRepository<Order>> _orderRepo = new Mock<IRepository<Order>>();
        private readonly Mock<IRepository<PermissionRecord>> _permissionRecord = new Mock<IRepository<PermissionRecord>>();
        private readonly Mock<IRepository<PermissionRecordCustomerRoleMapping>> _permissionRecordCustomerRoleMapping = new Mock<IRepository<PermissionRecordCustomerRoleMapping>>();
        private readonly Mock<IStoreContext> _storeContext = new Mock<IStoreContext>();

        [SetUp]
        public override void SetUp()
        {

            var discount1 = new Discount
            {
                Id = 1,
                DiscountType = DiscountType.AssignedToCategories,
                Name = "Discount 1",
                CouponCode = "DiscoutCoupon",
                RequiresCouponCode = true,
                UsePercentage = true,
                DiscountPercentage = 10,
                DiscountAmount = 0,
                DiscountLimitation = DiscountLimitationType.Unlimited,
                LimitationTimes = 0
            };
            var discount2 = new Discount
            {
                Id = 2,
                DiscountType = DiscountType.AssignedToSkus,
                Name = "Discount 2",
                UsePercentage = false,
                DiscountPercentage = 0,
                DiscountAmount = 5,
                RequiresCouponCode = true,
                CouponCode = "SecretCode",
                DiscountLimitation = DiscountLimitationType.NTimesPerCustomer,
                LimitationTimes = 3
            };
            var discountList = new List<Discount> { discount1, discount2 }.AsQueryable();
            var discountRequirement = new List<DiscountRequirement>().AsQueryable();
            _permissionService.Setup(x => x.Authorize(StandardPermissionProvider.ManageDiscounts)).Returns(true);
            _discountRepo.Setup(x => x.Table).Returns(discountList);
            _discountRepo.Setup(c => c.GetById(It.IsAny<int>())).Returns((int i) => discountList.FirstOrDefault(c => c.Id == i));
            _discountRequirementRepo.Setup(x => x.Table).Returns(discountRequirement);
            _discountRequirementRepo.Setup(dr => dr.Insert(It.IsAny<DiscountRequirement>())).Callback((DiscountRequirement i) =>
            {
                i.Id = discountRequirement.Count() > 0 ? discountRequirement.Max(x => x.Id) + 1 : 1;
                discountRequirement.ToList().Add(i);
            });
           
            _eventPublisher.Setup(x => x.Publish(It.IsAny<object>()));
            var staticCacheManager = new TestCacheManager();
            var pluginService = new FakePluginService();

            _discountPluginManager = new DiscountPluginManager(new Mock<ICustomerService>().Object, pluginService);
            _discountService = new DiscountService(
                new FakeCacheKeyService(),
                _customerService.Object,
                _discountPluginManager,
                _eventPublisher.Object,
                _localizationService.Object,
                _productService.Object,
                _discountRepo.Object,
                _discountRequirementRepo.Object,
                _discountUsageHistoryRepo.Object,
                _orderRepo.Object,
                staticCacheManager,
                _storeContext.Object);
        }

        [Test]
        public void ConfigureDiscountBadRequest()
        {

            var discountRulesCustomerRoles = new DiscountRulesCustomerRolesController(_customerService.Object,
                                                   _discountService, _localizationService.Object, _permissionService.Object, _settingService.Object);
            var model = new RequirementModel()
            {
                DiscountId = 0,
                RequirementId = 0
            };

            ActionResult result = (ActionResult)discountRulesCustomerRoles.Configure(model);

            Assert.IsInstanceOf<NotFoundObjectResult>(result);
            Assert.AreEqual(((NotFoundObjectResult)result).StatusCode, 404);
            var returnType = new { Errors = new[] { "" } };
            var jsonObject = JsonConvert.SerializeObject(((NotFoundObjectResult)result).Value);
            var resutlObj = JsonConvert.DeserializeAnonymousType(jsonObject, returnType);
            Assert.IsTrue(resutlObj.Errors.Count() > 0);
        }
        [Test]
        public void ConfigureDiscountCreateNew()
        {
            var discountRulesCustomerRoles = new DiscountRulesCustomerRolesController(_customerService.Object,
                                                  _discountService, _localizationService.Object, _permissionService.Object, _settingService.Object);

            var model = new RequirementModel()
            {
                DiscountId = 1,
                RequirementId = 0
            };

            RunWithTestServiceProvider(() =>
            {
                ActionResult result = (ActionResult)discountRulesCustomerRoles.Configure(model);
                Assert.IsInstanceOf<OkObjectResult>(result);
                Assert.AreEqual(((OkObjectResult)result).StatusCode, 200);
                var returnType = new { NewRequirementId = "" };
                var jsonObject = JsonConvert.SerializeObject(((OkObjectResult)result).Value);
                var dvalue = JsonConvert.DeserializeAnonymousType(jsonObject, returnType);
                int number = 0;
                
                Assert.IsTrue(int.TryParse(dvalue.NewRequirementId, out number));
            });
        }
        [Test]
        public void ConfigureDiscountNotExist()
        {
            var discountRulesCustomerRoles = new DiscountRulesCustomerRolesController(_customerService.Object,
                                                  _discountService, _localizationService.Object, _permissionService.Object, _settingService.Object);

            var model = new RequirementModel()
            {
                DiscountId = 3,
                RequirementId = 0                
            };

            RunWithTestServiceProvider(() =>
            {
                ActionResult result = (ActionResult)discountRulesCustomerRoles.Configure(model);
                Assert.IsInstanceOf<NotFoundObjectResult>(result);
                Assert.AreEqual(((NotFoundObjectResult)result).StatusCode, 404);
                var returnType = new { Errors = new[] { "" } };
                var jsonObject = JsonConvert.SerializeObject(((NotFoundObjectResult)result).Value); 
                var resutlObj = JsonConvert.DeserializeAnonymousType(jsonObject, returnType);
                Assert.AreEqual(resutlObj.Errors.FirstOrDefault(), "Discount could not be loaded");
            });
        }
    }
}