using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practical2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cart : ContentPage
    {
        public Cart()
        {
            InitializeComponent();

            btnBack.ImageSource = ImageSource.FromResource("Practical2.back.png");
            btnBag.ImageSource = ImageSource.FromResource("Practical2.bag.png");
            JacketOne.Source = ImageSource.FromResource("Practical2.itemfront.png");
            JacketTwo.Source = ImageSource.FromResource("Practical2.itemJacketTwo.png");
            price1.Source = ImageSource.FromResource("Practical2.pricesOneCart.png");
            price2.Source = ImageSource.FromResource("Practical2.priceTwoCart.png");
            btnDeleteFromCart.ImageSource = ImageSource.FromResource("Practical2.delete.png");
            btnDeleteFromCart2.ImageSource = ImageSource.FromResource("Practical2.delete.png");
            //checkOut.Source = ImageSource.FromResource("Practical2.arrowfull.png");

        }

        private void btnBack_Clicked(object sender, EventArgs e)
        {
            MainPage MP = new MainPage();
            Application.Current.MainPage = MP;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            CheckOut checkOut = new CheckOut();
            Application.Current.MainPage = checkOut;
        }
    }
}