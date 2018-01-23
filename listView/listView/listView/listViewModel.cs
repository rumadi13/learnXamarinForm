using System;
using System.Collections.Generic;
using System.Text;
using MvvmHelpers;

namespace listView
{
    class listViewModel : BaseViewModel
    {
        public List<dataModel> datanya = new List<dataModel>();
        public listViewModel()
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
