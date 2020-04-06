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
        public int Age { get; set; }
        public int Money { get; set; } = 20;
        public int Sex { get; set; }
        public int Nationality { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
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
        public bool ThereOrNo { get; set; }
        /*  public string ThereNo {
              get
              {
                  if(ThereOrNo)
                  {
                      ThereNo = "Здесь";
                  }
                  else
                  {
                      ThereNo = "С собой";
                  }
                  return ThereNo;
              }
              set
              {
                  ThereNo = value;
              }
          }*/
        public int MoneySpend { get; set; } = 20;
      /*  public bool MoneyEnough {
            get
            {
                if(Money-MoneySpend>0)
                {
                    MoneyEnough = true;
                }
                else
                {
                    MoneyEnough = false;
                }
                return MoneyEnough;
            }
            set
            {
                value = MoneyEnough;
            }
        }*/
    }
}
