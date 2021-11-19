using CheckDays.Pages;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CheckDays
{

    public partial class App : Application
    {
        public const string DATABASE_NAME = "checkerbase.db";
        public static DatebaseClases.RepositedDate database;
        public static DatebaseClases.RepositedDate Database
        {
            get
            {
                if (database == null)
                {
                    database = new DatebaseClases.RepositedDate(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainCheck());
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
