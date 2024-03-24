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
        }

        private void btnBack_Clicked(object sender, EventArgs e)
        {
            MainPage MP = new MainPage();
            Application.Current.MainPage = MP;
        }
    }
}