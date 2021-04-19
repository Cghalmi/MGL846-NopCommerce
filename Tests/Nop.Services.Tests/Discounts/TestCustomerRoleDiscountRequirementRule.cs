using System;
using System.Linq;
using Nop.Core.Infrastructure;
using Nop.Services.Configuration;
using Nop.Services.Customers;
using Nop.Services.Discounts;
using Nop.Services.Plugins;

namespace Nop.Services.Tests.Discounts
{
    public partial class TestCustomerRoleDiscountRequirementRule : BasePlugin, IDiscountRequirementRule
    {

        private const string SettingsKey = "DiscountRequirement.MustBeAssignedToCustomerRole-{0}";
        /// <summary>
        /// Check discount requirement
        /// </summary>
        /// <param name="request">Object that contains all information required to check the requirement (Current customer, discount, etc)</param>
        /// <returns>Result</returns>
        public DiscountRequirementValidationResult CheckRequirement(DiscountRequirementValidationRequest request)
        { 
            var _customerService = EngineContext.Current.Resolve<ICustomerService>();

            if (request == null)
                throw new ArgumentNullException(nameof(request));

            //invalid by default
            var result = new DiscountRequirementValidationResult();

            if (request.Customer == null)
                return result;


            //simulation of test 1 and 2 discount  
            int restrictedRoleId;
            //try to get saved restricted customer role identifier
            if (request.DiscountRequirementId == 1 || request.DiscountRequirementId == 2)
            {
                restrictedRoleId = request.DiscountRequirementId;
            }
            else
            {
                restrictedRoleId = 0;
            } 
            if (restrictedRoleId == 0)
                return result;

            //result is valid if the customer belongs to the restricted role
            result.IsValid = _customerService.GetCustomerRoles(request.Customer).Any(role => role.Id == restrictedRoleId);

            return result;
        }

        /// <summary>
        /// Get URL for rule configuration
        /// </summary>
        /// <param name="discountId">Discount identifier</param>
        /// <param name="discountRequirementId">Discount requirement identifier (if editing)</param>
        /// <returns>URL</returns>
        public string GetConfigurationUrl(int discountId, int? discountRequirementId)
        {
            throw new NotImplementedException();
        }
    }
}
