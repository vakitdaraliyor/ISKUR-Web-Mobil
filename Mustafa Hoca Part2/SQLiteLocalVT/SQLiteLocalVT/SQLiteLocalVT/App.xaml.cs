using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

namespace SQLiteLocalVT
{
    public partial class App : Application
    {
        SQLiteConnection con = DBClass.GetConnection("inka.db");
        public static DBClass db = new DBClass();
        public App()
        {
            InitializeComponent();

            db.CreateTable(); // tablo olusturduk

            MainPage = new NavigationPage(new NaviMain());
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
