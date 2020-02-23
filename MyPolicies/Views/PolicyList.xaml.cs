using MyPolicies.Models;
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
    public partial class PolicyList : ContentPage
    {
        PolicyDetailsViewModel policyListViewModel;
        public PolicyList()
        {
            InitializeComponent();
            BindingContext = policyListViewModel = new PolicyDetailsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (policyListViewModel.Policies.Count == 0)
                policyListViewModel.LoadPoliciesCommand.Execute(null);
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Policy;
            if (item == null)
                return;

            await Navigation.PushAsync(new PolicyDetails(item.PolicyNumber));

            // Manually deselect item.
            PolicyListView.SelectedItem = null;
        }
    }
}