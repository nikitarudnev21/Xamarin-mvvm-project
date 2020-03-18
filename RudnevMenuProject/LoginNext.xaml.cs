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
    public partial class LoginNext : ContentPage
    {
        public LoginNext()
        {
            InitializeComponent();
        }


        async void GoNext(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());

         /*   Menuu menuu = new Menuu();
            lblLog1.Text = menuu.Password +" "+ menuu.Login;
              if(menuu.Password==Pass.Text && menuu.Login == logentry.Text)
              {
               await Navigation.PushAsync(new MainPage());
             //   DisplayAlert("аывавы", "вфывфывыф", "ОК");
               }
              else
               {
                DisplayAlert("Ошибка", "Неверный логин или пароль", "ОК");
              }

            /*    if(RegistrationNext.getpass==Pass.Text && RegistrationNext.getlog==logentry.Text)
                {
                    //await Navigation.PushAsync(new MainPage());
                    DisplayAlert("sd", "Неверный логин или пароль", "ОК");
                }
                else
                {
                    DisplayAlert("Ошибка", "Неверный логин или пароль", "ОК");
                }*/
        }

        private async void Backk(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}