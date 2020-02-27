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

            if (!String.IsNullOrEmpty(menuu.Name))
            {
                App.Database.SaveItem(menuu);
            }
            this.Navigation.PopAsync();

        }
        private void DeleteMenu(object sender, EventArgs e)
        {
            var menuu = (Menuu)BindingContext;
            App.Database.DeleteItem(menuu.Id);
            this.Navigation.PopAsync();
        }
        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }

        private void First_Clicked(object sender, EventArgs e)
        {

        }
    }
}