using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using SQLite;
using Xamarin.Forms;

namespace RudnevMenuProject
{
    [Table("Menuu")]
    public class Menuu
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        private DateTime date;
        public bool birth { get; set; }
        public int Sex { get; set; }
        public bool sswitch { get; set; }
        public int DLeft { get; set; }
        public int Age { get; set; }
        public int Nationality { get; set; }
        public int BurgerChick { get; set; }
        public int BurgerPork { get; set; }
        public int BurgerBeef { get; set; }
        public int BurgerQuantity { get; set; }
        public int BurgerSize { get; set; }
        public int Fri { get; set; }
        public int FrirQuantity { get; set; }
        public int FrirSize { get; set; }
        public int Drink { get; set; }
        public int DrinkQuantity { get; set; }
        public int DrinkSize{ get; set; }
        public int Dish { get; set; }
        public int ThereOrNo { get; set; }
        public int Money { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
