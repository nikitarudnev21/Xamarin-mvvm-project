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
        public RegistrationNext()
        {
            InitializeComponent();
        }

        private async void GoNext(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void Cancel(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}