using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace listView
{
	public partial class MainPage : ContentPage
	{
        public List<dataModel> datanya = new List<dataModel>();

        public MainPage()
		{
			InitializeComponent();
            //var vm = new ngelist();
            //this.BindingContext = vm;
        }

        public void ngelist()
        {
            var list = new List<dataModel>
            {
                new dataModel
                {
                    name = "Andi",
                    age = "14"
                },
                new dataModel
                {
                    name = "Anto",
                    age = "17"
                },
                new dataModel
                {
                    name = "Yanti",
                    age = "20"
                }
            };
            datanya.AddRange(list);
        }
    }
}
