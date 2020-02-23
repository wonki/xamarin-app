using MyPolicies.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyPolicies.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PolicyDetails : ContentPage
    {
        private string policyNumber;
        PolicyDetailsViewModel policyDetailsViewModel;

        public PolicyDetails(string policyNumber)
        {
            InitializeComponent();
            this.policyNumber = policyNumber;
            BindingContext = policyDetailsViewModel = new PolicyDetailsViewModel();

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

           //Make API call to get data
        }
    }
}