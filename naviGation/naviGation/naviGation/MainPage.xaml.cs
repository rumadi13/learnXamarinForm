using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace naviGation
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        public async void navigation_clickedbutton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new secondPage());
        }
    }
}
