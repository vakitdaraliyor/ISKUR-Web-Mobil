using ListViewControl.Model;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewControl
{
    public partial class App : Application
    {
        public static PERSONELS personeller = new PERSONELS();
        public App()
        {
            InitializeComponent();

            MainPage = new MDP();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
