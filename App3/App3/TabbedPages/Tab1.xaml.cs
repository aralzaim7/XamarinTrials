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
    public partial class Tab1 : ContentPage
    {
        public Tab1()
        {
            InitializeComponent();
            myDatePicker.MinimumDate = DateTime.Now;
            myDatePicker.Format = "dd-MM-yyyy";




        }



        int i = 0;


        public void Button_Clicked(object sender, EventArgs e)
        {
            i++;



            if (i % 2 == 1)
            {
                loadicon.IsRunning = true;
                loadbutton.Text = "Stop me!";
                loadicon.IsVisible = true;

            }

            else
            {
                loadicon.IsRunning = false;
                loadbutton.Text = "Load me!";
                loadicon.IsVisible = false;
            }

        }

        private void DisplayAlert(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        private void myDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            DatePicker dp = (DatePicker)sender;

            DisplayAlert("Date changed!", "New selected date is: " + dp.Date.ToString(), "Alright!");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(textentry.Text)) DisplayAlert("Text empty!", "No text entered!", "Okito!");

            else DisplayAlert("Text changed!", "New Text is: " + textentry.Text, "Okito!");
        }


        private void Button_Clicked_2(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(texteditor.Text)) DisplayAlert("Text Editor empty!", "No text entered!", "Okito!");

            else DisplayAlert("Text Editor Property Change", texteditor.Text, "Ok!");
        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //  steppervalue.Text = e.NewValue.ToString();
        }

        private async Task Switch_Toggled(object sender, ToggledEventArgs e)
        {
            bool isOk = await DisplayAlert("Switch", e.Value.ToString(), "Ok", "Cancel");

            if (isOk) await DisplayAlert("OK", "isOk", "Ok");
            else await DisplayAlert("Cancel", "isCancel", "Cancel");

            return;
        }



    }
}