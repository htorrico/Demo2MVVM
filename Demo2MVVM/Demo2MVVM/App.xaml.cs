using Demo2MVVM.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo2MVVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PersonInsert();
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
