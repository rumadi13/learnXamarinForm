using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Tabbed
{
	public partial class App : Application
	{
        public App()
        {
            InitializeComponent();

            MainPage = new CarouselPage // change tabbedPage to Corousel Page
            {
                Children = { new MainPage(),
                                new Tabbedpage()  }
            };

        }

		//protected override void OnStart ()
		//{
		//	// Handle when your app starts
		//}

		//protected override void OnSleep ()
		//{
		//	// Handle when your app sleeps
		//}

		//protected override void OnResume ()
		//{
		//	// Handle when your app resumes
		//}
	}
}
