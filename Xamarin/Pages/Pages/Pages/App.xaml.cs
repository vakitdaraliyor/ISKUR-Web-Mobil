﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pages
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new NavigationPage(new GezinmeSayfasi());
            // MainPage = new SekmeSayfasi();
            // MainPage = new CarouselSayfasi();
            MainPage = new AnaDetaySayfa();
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