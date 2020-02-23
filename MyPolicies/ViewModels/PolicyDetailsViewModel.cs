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
        public Policy PolicyDetails { get; set; }
        public Command LoadPolicyDetailsCommand { get; set; }
        public string Title { get; set; }

        public PolicyDetailsViewModel(string policyNumber)
        {
            Title = "Policy Details";
            PolicyDetails = new Policy();
            LoadPolicyDetailsCommand = new Command(async () => await GetPolicyDetails(policyNumber));
        }

        async Task GetPolicyDetails(string policyNumber)
        {
            Policy policyDetails = new Policy();
            try
            {
                //make API call to get policy details

                PolicyDetails = await Task.FromResult(new Policy() {PolicyNumber=policyNumber, 
                    PolicyType= EnumExtensionHelper.GetEnumDescription(PolicyType.Car) });
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }



    }
}
