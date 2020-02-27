using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RudnevMenuProject
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "menu.db";
        public static MenuRepository database;
        public static MenuRepository Database // отображает изменения в базе данных
        {
            get
            {
                if (database == null)
                {
                    database = new MenuRepository(DATABASE_NAME);
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Registration())
            {
                BarBackgroundColor = Color.DarkGoldenrod
            };

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
