using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.Runtime.InteropServices;
using System.Net;

namespace Practical2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Registration : ContentPage
	{
		public Registration ()
		{
            InitializeComponent();
            logo.Source = ImageSource.FromResource("Practical2.vector.png");
		}

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            Login login = new Login();
            Application.Current.MainPage = login;

        }

        //protected override void OnAppearing()
        //{
        //    ShowUser();
        //}

        //private void ShowUser()
        //{
        //    Test.ItemsSource = App.Db.GetUsers();
        //}

        private void RegistrationButton_Clicked(object sender, EventArgs e)
        {
            string name = firstNameEntry.Text.Trim();
            string lastName = lastNameEntry.Text.Trim();
            string email = emailEntry.Text.Trim();
            string password = passwordEntry.Text.Trim();
            //if (passwordEntry != confirmPasswordEntry)
            //{
            //    await DisplayAlert("Error", "Пароли не совпадают", "Ok");
            //    return;
            //}
            Users user = new Users
            {
                Name = name,
                LasyName = lastName,
                Email = email,
                Password = password,
            };

            App.Db.SaveUser(user);
            //ShowUser();

            firstNameEntry.Text = "";
            lastNameEntry.Text = "";
            emailEntry.Text = "";
            passwordEntry.Text = "";

        }
    }
}