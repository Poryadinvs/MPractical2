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
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("Practical2.vector.png");
            btnBack.ImageSource = ImageSource.FromResource("Practical2.back.png");
            btnBag.ImageSource = ImageSource.FromResource("Practical2.bag.png");
            item1.Source = ImageSource.FromResource("Practical2.itempagetwo.png");
            grade.Source = ImageSource.FromResource("Practical2.grade.png");
            itemBack.Source = ImageSource.FromResource("Practical2.itemback.png");
            itemFront.Source = ImageSource.FromResource("Practical2.itemfront.png");
            itemClose.Source = ImageSource.FromResource("Practical2.itemclose.png");
            toWishList.Source = ImageSource.FromResource("Practical2.frame.png");
            checkOut.Source = ImageSource.FromResource("Practical2.arrowfull.png");
        }

        private void btnBack_Clicked(object sender, EventArgs e)
        {
            MainPage MP = new MainPage();
            Application.Current.MainPage = MP;
        }
    }
}