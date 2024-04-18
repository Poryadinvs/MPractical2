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
	public partial class Login : ContentPage
	{
		public Login ()
		{
            InitializeComponent();
            logo.Source = ImageSource.FromResource("Practical2.vector.png");
		}

        private void RegistrationButton_Clicked(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            Application.Current.MainPage = registration;
        }

        private async void EnterButton_Clicked(object sender, EventArgs e)
        {
            string email = emailEntry.Text.Trim();
            string password = passwordEntry.Text.Trim();

            List<Users> users = App.Db.GetUsers();

            Users user = users.FirstOrDefault(u => u.Email == email && u.Password == password);

            if (user != null)
            {
                MainPage mainPage = new MainPage();
                Application.Current.MainPage = mainPage;
            }
            else
            {
                await DisplayAlert("Error", "Нверный пароль или email", "Ok");
            }

        }
    }
}