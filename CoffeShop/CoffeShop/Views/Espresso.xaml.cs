using CoffeShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoffeShop.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Espresso : ContentPage
    {
        public Espresso()
        {
            InitializeComponent();
            BindingContext = new EspressoViewModels1();
        }
    }
}