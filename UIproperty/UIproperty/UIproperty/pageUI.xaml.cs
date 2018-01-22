using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UIproperty
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class pageUI : ContentPage
	{
		public pageUI ()
		{
			InitializeComponent ();
		}

        public void button_LabelonClicked()
        {
            var text = MainEntry.Text;
            MainLabel.Text = "Hello " + text + " Ganteng";
        }
    }
}