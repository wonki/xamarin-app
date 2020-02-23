using MyPolicies.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyPolicies.Services
{
    public class MockDataStore : IDataStore<Policy>
    {
        readonly List<Policy> policies;
        public MockDataStore()
        {
            policies = new List<Policy> { new Policy { PolicyNumber = "9988776655" ,
                PolicyType = EnumExtensionHelper.GetEnumDescription(PolicyType.Car) },
            new Policy { PolicyNumber = "6767454534" ,
                PolicyType = EnumExtensionHelper.GetEnumDescription(PolicyType.Motorcycle) } };

        }
        public async Task<IEnumerable<Policy>> GetPoliciesAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(policies);
        }
    }
}
