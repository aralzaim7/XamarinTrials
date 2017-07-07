using App3.MasterPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3.Views
{
    public class MyMasterPage : MasterDetailPage
    {
        public MyMasterPage()
        {


            Master = new MyMenu();
            Detail = new TabbedPage1();
        }
    }
}
