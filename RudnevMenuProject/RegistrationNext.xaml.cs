using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RudnevMenuProject
{
   // [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationNext : ContentPage
    {
        public static string getlog;
        public static string getpass;
        Menuu menuu = new Menuu();
        public RegistrationNext()
        {
            InitializeComponent();
           /* menuu.Password = "";
            menuu.Login = "";*/
        }

        private async void GoNext(object sender, EventArgs e)
        {
            /*  getlog = Elog.Text;
              getpass = Epass.Text;
              menuu.Password = getpass;
              menuu.Login = getlog;*/
            /*var menuu = (Menuu)BindingContext;
            App.database.SaveItem(menuu);*/
            await Navigation.PushAsync(new LoginNext());
        }

        private async void Cancel(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}