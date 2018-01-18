using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicAndroid
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
		}

        private void button_onClicked(object sender, EventArgs e)
        {
            var text = MainEntry.Text;
            MainLabel.Text = "Hallo " + text + " Ganteng :)" ;
        }

    }
}