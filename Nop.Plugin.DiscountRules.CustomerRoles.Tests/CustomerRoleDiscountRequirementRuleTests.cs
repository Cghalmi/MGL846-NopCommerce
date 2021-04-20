using Microsoft.AspNetCore.Mvc;
using Moq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Nop.Core;
using Nop.Core.Caching;
using Nop.Core.Domain.Customers;
using Nop.Core.Domain.Discounts;
using Nop.Core.Domain.Orders;
using Nop.Core.Domain.Security;
using Nop.Core.Infrastructure;
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
using Nop.Services.Tests.FakeServices.Providers;
using Nop.Tests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Nop.Plugin.DiscountRules.CustomerRoles.Tests
{
    [TestFixture]
    public class CustomerRoleDiscountRequirementRuleTests : ServiceTest
    {
        private const string SystemName = "TestCustomerRoleDiscountRequirementRule"; 
        private IDiscountPluginManager _discountPluginManager; 
        private Mock<IRepository<CustomerCustomerRoleMapping>> _customerCustomerRoleMapping = new Mock<IRepository<CustomerCustomerRoleMapping>>();
        private readonly Mock<ICustomerService> _customerService = new Mock<ICustomerService>();
        private readonly Mock<IRepository<Discount>> _discountRepo = new Mock<IRepository<Discount>>();
        private readonly Mock<IRepository<DiscountRequirement>> _discountRequirementRepo = new Mock<IRepository<DiscountRequirement>>();

        private readonly CustomerRole _customerRoleAdmin = new CustomerRole
        {
            Id = 1,
            Active = true,
            Name = "Administrators",
            SystemName = NopCustomerDefaults.AdministratorsRoleName
        };

        private readonly CustomerRole _customerRoleGuests = new CustomerRole
        {
            Id = 2,
            Active = true,
            Name = "Guests",
            SystemName = NopCustomerDefaults.GuestsRoleName
        };

        private readonly CustomerRole _customerRoleRegistered = new CustomerRole
        {
            Id = 3,
            Active = true,
            Name = "Registered",
            SystemName = NopCustomerDefaults.RegisteredRoleName
        };

        private readonly CustomerRole _customerRoleForumModerators = new CustomerRole
        {
            Id = 4,
            Active = true,
            Name = "ForumModerators",
            SystemName = NopCustomerDefaults.ForumModeratorsRoleName
        };

        private readonly CustomerRole _customerRole1 = new CustomerRole
        {
            Id = 5,
            Active = true,
            Name = "Test name 1",
            SystemName = "Test system name 1"
        };

        private readonly CustomerRole _customerRole2 = new CustomerRole
        {
            Id = 6,
            Active = false,
            Name = "Test name 2",
            SystemName = "Test system name 2"
        };
        private Discount discount1 = new Discount
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
        private Discount discount2 = new Discount
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
        private DiscountRequirement discountRequirement1 = new DiscountRequirement()
        {
            DiscountId = 1,
            Id = 1,
        };
        private DiscountRequirement discountRequirement2 = new DiscountRequirement()
        {
            DiscountId = 1,
            Id = 2,
        };
        private IQueryable<CustomerCustomerRoleMapping> rm;
        private IList<CustomerRole> Roles()
        {
            return new List<CustomerRole>
            {
                _customerRoleAdmin,
                _customerRoleGuests,
                _customerRoleRegistered,
                _customerRoleForumModerators,
                _customerRole1,
                _customerRole2
            };
        }
        private IList<DiscountRequirement> DiscountRequirements()
        {
            return new List<DiscountRequirement>
            {
               discountRequirement1,
               discountRequirement2
            };
        }
        private IList<Discount> Discounts()
        {
            return new List<Discount>
            {
                discount1,
                discount2
            };
        }

        [SetUp]
        public override void SetUp()
        {

            rm = new List<CustomerCustomerRoleMapping>
                {
                    new CustomerCustomerRoleMapping
                    {
                        CustomerRoleId = _customerRoleRegistered.Id,
                        CustomerId = 1
                    },
                    new CustomerCustomerRoleMapping
                    {
                        CustomerRoleId = _customerRoleAdmin.Id,
                        CustomerId = 1
                    }
                }.AsQueryable();
            _discountRepo.Setup(x => x.Table).Returns(Discounts().AsQueryable());
            _discountRepo.Setup(c => c.GetById(It.IsAny<int>())).Returns((int i) => Discounts().FirstOrDefault(c => c.Id == i));
            _discountRequirementRepo.Setup(x => x.Table).Returns(DiscountRequirements().AsQueryable());
            _discountRequirementRepo.Setup(dr => dr.Insert(It.IsAny<DiscountRequirement>())).Callback((DiscountRequirement i) =>
             {
                 i.Id = DiscountRequirements().Count() > 0 ? DiscountRequirements().Max(x => x.Id) + 1 : 1;
                 DiscountRequirements().Add(i);
             }); 
            _customerCustomerRoleMapping.Setup(x => x.Table).Returns(rm);
            _customerService.Setup(x => x.GetCustomerRoles(It.IsAny<Customer>(), false)).Returns((Customer i, bool f) =>
            {
                var roles = Roles().Where(y => rm.Where(x => x.CustomerId == i.Id).Select(x => x.CustomerRoleId).Contains(y.Id));
                return roles.ToList();
            });

            var pluginService = new FakePluginService(customerService: _customerService.Object);

            _discountPluginManager = new DiscountPluginManager(_customerService.Object, pluginService);

        }
        [Test]
        public void CheckRequirement_Request_Null()
        {
            RunWithTestServiceProvider(() =>
            {
                var rule = _discountPluginManager.LoadPluginBySystemName(SystemName);
                try
                {
                    var result = rule.CheckRequirement(null);
                }
                catch (ArgumentException ex)
                {

                    Assert.IsInstanceOf<ArgumentNullException>(ex);
                    Assert.AreEqual("Value cannot be null. (Parameter 'request')", ex.Message);
                    Assert.AreEqual("request", ex.ParamName);
                }
            });
        }
        [Test]
        public void CheckRequirement_Customer_Null()
        {
            RunWithTestServiceProvider(() =>
            {
                var rule = _discountPluginManager.LoadPluginBySystemName(SystemName);

                var result = rule.CheckRequirement(new DiscountRequirementValidationRequest()
                {
                    DiscountRequirementId = 1,
                    Store = null,
                    Customer = null
                });
                 
                Assert.IsInstanceOf<DiscountRequirementValidationResult>(result);
                Assert.AreEqual(result.IsValid, false);
                 
            });
        }
        [Test]
        public void CheckRequirement_restrictedRoleId_NotExist()
        {
            RunWithTestServiceProvider(() =>
            {
                var rule = _discountPluginManager.LoadPluginBySystemName(SystemName);

                var result = rule.CheckRequirement(new DiscountRequirementValidationRequest()
                {
                    DiscountRequirementId = 3,
                    Store = null,
                    Customer = new Customer()
                });

                Assert.IsInstanceOf<DiscountRequirementValidationResult>(result);
                Assert.AreEqual(result.IsValid, false);
            });
        }

        [Test]
        public void CheckRequirement_restrictedRoleId_Valid()
        {
            var serviceProvider = new FakeServiceProvider(_customerService.Object);
            var nopEngine = new FakeNopEngine(serviceProvider);
            EngineContext.Replace(nopEngine);


            var rule = _discountPluginManager.LoadPluginBySystemName(SystemName);

            var result = rule.CheckRequirement(new DiscountRequirementValidationRequest()
            {
                DiscountRequirementId = 1,
                Store = null,
                Customer = new Customer() { Id = 1 }
            });

            Assert.IsInstanceOf<DiscountRequirementValidationResult>(result);
            Assert.AreEqual(result.IsValid, true);
            EngineContext.Replace(null);
        }
    }
}