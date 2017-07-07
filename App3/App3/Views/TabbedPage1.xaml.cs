using App3.TabbedPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage1 : TabbedPage
    {
        public TabbedPage1()
        {
            Children.Add(new Tab1());
            Children.Add(new Tab2());
            Children.Add(new Tab3());
          
            Title = "METU NCC MOBILE";

        }
    }
}