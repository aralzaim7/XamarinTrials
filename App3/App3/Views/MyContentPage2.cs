using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App3.Views
{
    public class MyContentPage2 : ContentPage
    {
        public MyContentPage2()
        {

            Label lblPage = new Label();
            lblPage.Text = "Merhaba MyContentPage2!";
            lblPage.FontSize = 30;
            lblPage.HorizontalOptions = LayoutOptions.Center;
            lblPage.VerticalOptions = LayoutOptions.Center;

            Content = lblPage;



        }
    }
}