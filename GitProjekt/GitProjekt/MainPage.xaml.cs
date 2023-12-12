using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GitProjekt
{
    public partial class MainPage : ContentPage
    {
        private Produkt wybranyProdukt;
        internal ObservableCollection<Produkt> produkty = new ObservableCollection<Produkt>();

        protected override void OnAppearing()
        {
            base.OnAppearing();
            AktualizujListe();
        }
        public MainPage()
        {
            InitializeComponent();
            OnAppearing();
        }
        private void AktualizujListe()
        {
            lista.ItemsSource = null;
            lista.ItemsSource = produkty;
        }

        private void Dodaj_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ManageProduct(produkty));
            AktualizujListe();
        }

        private void Edytuj_Clicked(object sender, EventArgs e)
        {
            Produkt wybranyProdukt = (Produkt)lista.SelectedItem;
            Navigation.PushAsync(new ManageProduct(wybranyProdukt));
            AktualizujListe();
        }

        private void Usun_Clicked(object sender, EventArgs e)
        {
            Produkt produkt = (Produkt)lista.SelectedItem;
            produkty.Remove(produkt);
            AktualizujListe();

        }
    }
}
