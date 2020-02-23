using MyPolicies.Services;
using MyPolicies.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyPolicies
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //change this to read from local SQLite
            DependencyService.Register<MockDataStore>();

            MainPage = new Dashboard();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
