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

            ContentPage tab1= new Tab1();
   //         tab1.Icon = "controls.png";

            ContentPage tab2 = new Tab2();
    //        tab2.Icon = "data.png";

            ContentPage tab3 = new Tab3();
      //      tab3.Icon = "webview.png";

            ContentPage tab4 = new Tab4();
     //       tab4.Icon = "grid.png";

            Children.Add(tab1);
            Children.Add(tab2);
            Children.Add(tab3);
            Children.Add(tab4);
            Title = "METU NCC MOBILE";

        }
    }
}