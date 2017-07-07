using App3.Model;
using App3.Provider;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3.TabbedPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tab2 : ContentPage
    {

        readonly ServiceManager manager = new ServiceManager();


        public Tab2()
        {

            InitializeComponent();
            Padding = new Thickness(0, 30, 0, 0);
            Title = "FetchData";
            getdataload.IsVisible = false;

        }


        public void Button_Clicked(object sender, EventArgs e)
        {
            getdataload.IsRunning = true;
            getdataload.IsVisible = true;
            LoadData();
        }


        //clicked on the Get Data button
        private async void LoadData()
        {
            try
            {

                var js = await manager.GetAll();
                lst.BindingContext = js.phonebook;
                lst.IsVisible = true;
                getdataload.IsRunning = false;
                getdataload.IsVisible = false;

            }


            catch (Exception e)
            {
                await DisplayAlert("Oops", e.ToString(), "Tamam");
                getdataload.IsRunning = false;
                getdataload.IsVisible = false;
            }
            finally
            {
                getdataload.IsRunning = false;
                getdataload.IsVisible = false;
            }
        }


        //clicked on the listview item
        private void lst_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }

            PhoneBook selected = (PhoneBook)e.SelectedItem;
            DisplayAlert(selected.FirstLastName, selected.name, "Ok");

            ListView listview = (ListView)sender;
            listview.SelectedItem = null;
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var selectedPersonal = (PhoneBook)menuItem.CommandParameter;

            DisplayAlert("Oo!", "You tried to delete " + selectedPersonal.FirstLastName + "'s Data!", "Ok!");
        }

        private void MenuItem_Clicked_1(object sender, EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var selectedPersonal = (PhoneBook)menuItem.CommandParameter;
            DisplayAlert("Ooh!", "Email address is:  " + selectedPersonal.email, "Ok!");
        }

        private void lst_Refreshing(object sender, EventArgs e)
        {
            DisplayAlert("Refresh!", "Yeah, refresh it!", "Ok");
            lst.IsRefreshing = false;
        }
    }
}