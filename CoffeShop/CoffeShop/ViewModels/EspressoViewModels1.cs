using CoffeShop.Models;
using CoffeShop.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CoffeShop.ViewModels
{
    public class EspressoViewModels1
    {
        private ObservableCollection<FoodList> _FoodList;
        public ObservableCollection<FoodList> FoodsList
        {
            get { return _FoodList;  }
            set
            {
                _FoodList = value;
            }
        }
        public EspressoViewModels1()
        {
            _FoodList = new ObservableCollection<FoodList>();

            EspressoNameData _context = new EspressoNameData();

            foreach(var foodList in _context.FoodList)
            {
                _FoodList.Add(foodList);
            }
        }
    }
}
