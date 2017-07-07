using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3.TabbedPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tab3 : ContentPage
    {
        public Tab3()
        {
            InitializeComponent();
            Padding = new Thickness(0, 30, 0, 0);
            Title = "WebView";



            WebView wView = new WebView
            {
                Source = new UrlWebViewSource
                {
                    Url = "https://ncc.metu.edu.tr",
                },

                HeightRequest = 1000,
                WidthRequest = 1000,

            };




            StackLayout sl = new StackLayout();

            sl.Children.Add(wView);

            this.Content = sl;

        }
    }
}