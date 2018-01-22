using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace passing
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        public void button_onClicked(object sender, EventArgs e  )
        {
            var text = MainEntry.Text;
            mainLabel.Text = text + " Ganteng";
            //await Navigation.PushAsync(new Page1(MainEntry.Text));
        }

        public async void passing_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1(MainEntry.Text));
        }
    }
}
