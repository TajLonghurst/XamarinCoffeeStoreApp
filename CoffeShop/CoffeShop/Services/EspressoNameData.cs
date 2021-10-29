using CoffeShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeShop.Services
{
    public class EspressoNameData
    {
        public List<FoodList> FoodList = new List<FoodList>()
        {
            new FoodList()
            {
                EspressoID = 1,
                EspressoName = "Cafe Americano",
                EspressoPrice = "$2.50"
            },
            new FoodList()
            {
                EspressoID = 2,
                EspressoName = "Thousands",
                EspressoPrice = "$4.50"
            },
            new FoodList()
            { 
                EspressoID = 2,
                EspressoName = "Cappucino",
                EspressoPrice ="$6,60"
            }
        };
    }
}
