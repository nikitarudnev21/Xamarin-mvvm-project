using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RudnevMenuProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public static bool start { get; set; }

        public MenuPage()
        {
            InitializeComponent();
            //DP.MaximumDate = DateTime.Now;
        }
        private void SaveMenu(object sender, EventArgs e)
        {
            var menuu = (Menuu)BindingContext;
            if(entrychick.Text!="0" && entrypork.Text!="0" && entrybeef.Text!= "0")
            {
                if (!String.IsNullOrEmpty(menuu.BurgerBeef.ToString()) && !String.IsNullOrEmpty(menuu.BurgerChick.ToString())
                 && !String.IsNullOrEmpty(menuu.BurgerPork.ToString()))
                {
                    App.Database.SaveItem(menuu);
                    this.Navigation.PopAsync();
                }
            }
            else
            {
                DisplayAlert("Ошибка", "Заполните поля правильно", "ОК");
            }
        }
        private void DeleteMenu(object sender, EventArgs e)
        {
            var menuu = (Menuu)BindingContext;
            App.Database.DeleteItem(menuu.Id);
            this.Navigation.PopAsync();
        }
        private void Cancel(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void First_Clicked(object sender, EventArgs e)
        {

        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
        /*    if(entrybeef.Text!=null)
            {
                int conv = Convert.ToInt32(entrybeef.Text);
                if (conv > 100)
                {
                    conv = 100;
                }
                if (conv < 1)
                {
                    conv = 1;
                }
                entrybeef.Text = conv.ToString();
            }*/

        }

        private void Entry_TextChanged_1(object sender, TextChangedEventArgs e)
        {
         /*   if (entrychick.Text != null)
            {
                int conv = Convert.ToInt32(entrychick.Text);
                if (conv > 100)
                {
                    conv = 100;
                }
                if (conv < 1)
                {
                    conv = 1;
                }
                entrychick.Text = conv.ToString();
            }*/
        }

        private void Entry_TextChanged_2(object sender, TextChangedEventArgs e)
        {
       /*     if (entrypork.Text != null)
            {
                int conv = Convert.ToInt32(entrypork.Text);
                if (conv > 100)
                {
                    conv = 100;
                }
                if (conv < 1)
                {
                    conv = 1;
                }
                entrypork.Text = conv.ToString();
            }*/
        }
    }
}