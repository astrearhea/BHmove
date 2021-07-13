using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Movie_app
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DodajPage : ContentPage
    {
        public DodajPage()
        {
            InitializeComponent();
        }
        void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender; int selectedIndex = picker.SelectedIndex; if (selectedIndex != -1)
            {
                zanr.Text = (string)picker.ItemsSource[selectedIndex];
            }
        }

        private async void dodajNaListu_Clicked(object sender, EventArgs e)
        {
            var film = $"Naziv filma: {naziv.Text}\n \n" + $"Glavni glumac: {glavniGlumac.Text}\n" + $"Producent: {producent.Text}\n \n" + $"Godina izdavanja: {godinaIzdavanja.Text} \n";
            
            DisplayAlert(zanr.Text, film , "Uspješno ste dodali film za kasnije gledanje", "OK");
        }
    } 
}