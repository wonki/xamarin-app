using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyPolicies.Services
{
    public interface IDataStore<T>  
    {
        Task<IEnumerable<T>> GetPoliciesAsync(bool forceRefresh = false);
    }
}
