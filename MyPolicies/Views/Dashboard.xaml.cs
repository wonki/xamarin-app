using MyPolicies.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyPolicies.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class Dashboard : ContentPage
    {
        DashboardViewModel dashboardListViewModel;

        public Dashboard()
        {
            InitializeComponent();
            BindingContext = dashboardListViewModel = new DashboardViewModel();
        }
              

        async void OnMyPoliciesClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new PolicyList()));
        }

        private void OnAddCarClicked(object sender, EventArgs e)
        {

        }

        private void OnAddMotorcycleClicked(object sender, EventArgs e)
        {

        }
    }
}
