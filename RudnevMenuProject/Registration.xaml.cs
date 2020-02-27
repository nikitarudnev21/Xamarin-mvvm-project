using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RudnevMenuProject
{
  //  [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registration : ContentPage
    {
        public Registration()
        {
            InitializeComponent();
        }

        private async void Login(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginNext());
        }

        private async void Registrationn(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationNext());
        }

        private async void Exitt(object sender, EventArgs e)
        {
            bool result2 = await DisplayAlert("Подтвердите действие", "Вы действительно хотите выйти?", "Да", "Нет");
            if (result2 == true)
            {
                System.Environment.Exit(0);
                // Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
            }
        }
    }
}