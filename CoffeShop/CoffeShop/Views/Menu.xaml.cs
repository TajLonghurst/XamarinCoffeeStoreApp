using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using System.Windows.Input;
using Plugin.Share;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoffeShop.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()   
        {
            InitializeComponent();
            BindingContext = this;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.instagram.com/");
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {

        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.facebook.com");
        }
    }
}