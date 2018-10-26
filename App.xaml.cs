using System;

using LemmaApp.Views;
using Xamarin.Forms;
using LemmaApp.Percistence;
using System.IO;

namespace LemmaApp
{
	public partial class App : Application
	{
        static BDD database;
        public App ()
		{
			InitializeComponent();


            MainPage = new MainPage();
        }
        public static BDD Database
        {
            get
            {
                if (database == null)
                {
                    database = new BDD(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "BDDSQLite.db3"));
                }
                return database;
            }
        }
        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
