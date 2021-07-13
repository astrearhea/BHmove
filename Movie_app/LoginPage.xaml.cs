using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Movie_app
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnRegister_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistrationPage());
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            if( Application.Current.Properties.ContainsKey("Username")
                && Application.Current.Properties.ContainsKey("Password"))
            {
                var username = Application.Current.Properties["Username"] as String;
                var password = Application.Current.Properties["Password"] as String;
                if (entryUserName.Text == username && entryPassword.Text == password)
                {
                    
                    DisplayAlert("Prijava uspješna!", "Dobrodošli! ", "OK");
                }
                else
                {
                    DisplayAlert("", "Prijava nije uspjela!", "OK");
                }
            }
            else {
                DisplayAlert("", "Prijava nije uspjela!", "OK");
            }
            
        }
    }
}