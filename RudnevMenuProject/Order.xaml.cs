using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RudnevMenuProject
{
    [DesignTimeVisible(false)]
    public partial class Order : ContentPage
    {
        public Order()
        {
            InitializeComponent();
            Menuu menuu = new Menuu();
            if(menuu.ThereOrNo)
            {
                
            }
            else
            {

            }
        }
        protected override void OnAppearing()
        {
            MenuList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Menuu selectedMenu = (Menuu)e.SelectedItem;
            MenuPage menuPage = new MenuPage();
            menuPage.BindingContext = selectedMenu;
            await Navigation.PushAsync(menuPage);
        }

        private async void AddToOrder(object sender, EventArgs e)
        {
            Menuu menuu = new Menuu();
            MenuPage menuPage = new MenuPage();
            menuPage.BindingContext = menuu;
            await Navigation.PushAsync(menuPage);
        }

        private async void Cancel(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}