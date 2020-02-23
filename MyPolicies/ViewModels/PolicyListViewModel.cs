using MyPolicies.Models;
using MyPolicies.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyPolicies.ViewModels
{
    public class PolicyDetailsViewModel
    {
        public ObservableCollection<Policy> Policies { get; set; }
        public Command LoadPoliciesCommand { get; set; }
        public IDataStore<Policy> DataStore => DependencyService.Get<IDataStore<Policy>>();
        public string Title { get; set; }

        public PolicyDetailsViewModel()
        {
            Title = "Policy List";
            Policies = new ObservableCollection<Policy>();
            LoadPoliciesCommand = new Command(async () => await GetPolicies());
        }

        async Task GetPolicies()
        {
            try
            {
                Policies.Clear();
                var policyList = await DataStore.GetPoliciesAsync(true);
                foreach (var policy in policyList)
                {
                    Policies.Add(policy);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }            
        }
    }
}
