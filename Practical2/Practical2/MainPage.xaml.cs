using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Practical2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            logo.Source = ImageSource.FromResource("Practical2.vector.png");
            btnCategory.ImageSource = ImageSource.FromResource("Practical2.category.png");
            btnBag.ImageSource = ImageSource.FromResource("Practical2.bag.png");
            arrowFull.Source = ImageSource.FromResource("Practical2.arrowfull.png");
            arrowMt.Source = ImageSource.FromResource("Practical2.arrofmt.png");
            arrowFull.Aspect = Aspect.Fill;
            arrowMt.Aspect = Aspect.Fill;
            item1.Source = ImageSource.FromResource("Practical2.itemone.png");
            item2.Source = ImageSource.FromResource("Practical2.itemtwo.png");
            grade.Source = ImageSource.FromResource("Practical2.grade.png");
            grade2.Source = ImageSource.FromResource("Practical2.grade.png");
            price1.Source = ImageSource.FromResource("Practical2.priceone.png");
            price2.Source = ImageSource.FromResource("Practical2.pricetwo.png");
            btnToCart.ImageSource = ImageSource.FromResource("Practical2.itemcart.png");
            btnToCart2.ImageSource = ImageSource.FromResource("Practical2.itemcart.png");


        }

        private async void btnCategory_Clicked(object sender, EventArgs e)
        {
            Page2 page2 = new Page2(); 
            Application.Current.MainPage = page2;
        }
    }
}
