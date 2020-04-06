using Plugin.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RudnevMenuProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public string thereOrNo { get; set; }
        public MenuPage()
        {
            InitializeComponent();
            //DP.MaximumDate = DateTime.Now;
        }
        private async void SaveMenu(object sender, EventArgs e)
        {
            var menuu = (Menuu)BindingContext;
            if (entrychick.Text != "0" || entrypork.Text != "0" || entrybeef.Text != "0")
            {
                if (entrychick.Text.Length != 0 || entrypork.Text.Length != 0 || entrybeef.Text.Length != 0)
                {
                    string order = "";
                    if(entrychick.Text!="0")
                    {
                        order +=  entrychick.Text +" " +"бургер с курицей" + "\n";
                    }
                    if (entrypork.Text!="0")
                    {
                        order +=  entrypork.Text +" " +"бургер со свининой" + "\n";
                    }
                    if (entrybeef.Text!="0")
                    {
                        order +=  entrybeef.Text + " " + "бургер с говядиной" + "\n";
                    }
                    if (switch1.IsToggled)
                    {
                        thereOrNo = "здесь";
                    }
                    else
                    {
                        thereOrNo = "с собой";
                    }
                    var actionSheet = await DisplayActionSheet("Каким способом вы хотите получить чек о покупке?",
                            "Мне не нужен чек", "", "При помощи SMS",
                          "При помощи письма", "В другом приложении");
                        switch (actionSheet)
                        {
                            case "Мне не нужен чек":
                                break;
                            case "При помощи SMS":
                                var smsMessanger = CrossMessaging.Current.SmsMessenger;
                                if (smsMessanger.CanSendSms)
                                {
                                   smsMessanger.SendSms(menuu.Phone, "Чек о покупке в ресторане Nburger.\n" + 
                                       "Ваш заказ:\n" +
                                       "Дата и время покупки:" + DateTime.Now + "\n" +
                                        "Вы заказали:" + "\n" + order +
                                       "Вы потратили: " + menuu.MoneySpend +"евро" + "\n" +
                                       "Вы выбрали есть заказ:" + thereOrNo);
                                }
                                break;
                            case "При помощи письма":
                                var emailMessenger = CrossMessaging.Current.EmailMessenger;
                            if (emailMessenger.CanSendEmail)
                            {
                                emailMessenger.SendEmail(menuu.Email, "Чек от Nburger", "Чек о покупке в ресторане Nburger.\n" +
                                   "Ваш заказ:\n" +
                                   "Дата и время покупки:" + DateTime.Now + "\n" +
                                    "Вы заказали:" + "\n" + order +
                                        "Вы потратили: " + menuu.MoneySpend + "\n" +
                                       "Вы выбрали есть заказ:" + thereOrNo);
                                }
                                break;
                            case "В другом приложении":
                                await Share.RequestAsync(new ShareTextRequest
                                {
                                    Text =
                                    "Чек о покупке в ресторане Nburger.\n" +
                                    "Ваш заказ:\n" +
                                    "Дата и время покупки:" + DateTime.Now + "\n" +
                                     "Вы заказали:" + "\n" + order +
                                    "Вы потратили: " + menuu.MoneySpend + "\n" +
                                    "Вы выбрали есть заказ:" + thereOrNo,
                                    Title = "Поделиться заказом",
                                });
                                break;
                        }
                        App.Database.SaveItem(menuu);
                    await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("Ошибка", "Заполните поля правильно", "ОК");
                }
            }
        }
        private async void DeleteMenu(object sender, EventArgs e)
        {
            var menuu = (Menuu)BindingContext;
            App.Database.DeleteItem(menuu.Id);
            await Navigation.PopAsync();
        }
        private async void Cancel(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
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