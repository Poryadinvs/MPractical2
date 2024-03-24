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
    public partial class CheckOut : ContentPage
    {
        public CheckOut()
        {
            InitializeComponent();
            btnBack.ImageSource = ImageSource.FromResource("Practical2.back.png");
            btnBag.ImageSource = ImageSource.FromResource("Practical2.bag.png");
            dots.Source = ImageSource.FromResource("Practical2.dots.png");
            dots2.Source = ImageSource.FromResource("Practical2.dots.png");
            dots3.Source = ImageSource.FromResource("Practical2.dots.png");
            card.Source = ImageSource.FromResource("Practical2.card.png");
            masterCard.ImageSource = ImageSource.FromResource("Practical2.MasterCard.png");
            applePay.ImageSource = ImageSource.FromResource("Practical2.applePay.png");
            payPal.ImageSource = ImageSource.FromResource("Practical2.PayPal.png");
            visa.ImageSource = ImageSource.FromResource("Practical2.visa.png");
            checkOut.Source = ImageSource.FromResource("Practical2.arrowfull.png");

        }

        private void btnBack_Clicked(object sender, EventArgs e)
        {
            MainPage MP = new MainPage();
            Application.Current.MainPage = MP;
        }
    }
}