using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GitProjekt
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ManageProduct : ContentPage
	{
		public ManageProduct ()
		{
			InitializeComponent();
		}

        public ManageProduct(Produkt wybranyProdukt)
        {
            InitializeComponent();
			labelTytul.Text = "Edytuj produkt";
			btnDodaj.IsVisible = false;
			btnEdytuj.IsVisible = true;
        }

		private void BtnDodajClicked(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(entryNazwa.Text) && !string.IsNullOrEmpty(entryCena.Text) && !string.IsNullOrEmpty(entryIlosc.Text))
			{
                if (int.TryParse(entryIlosc.Text, out int _) && decimal.TryParse(entryCena.Text, out decimal _))
                {
                    var produkt = new Produkt()
                    {
                        Nazwa = entryNazwa.Text,
                        Cena = Decimal.Parse(entryCena.Text),
                        Ilosc = int.Parse(entryIlosc.Text)
                    };

                    produkty.Add(produkt);

                    entryNazwa.Text = string.Empty;

                    entryCena.Text = string.Empty;

                    entryIlosc.Text = string.Empty;

                }
                else
                {
                    DisplayAlert("Niepoprawne dane", "Pole cena lub ilość nie jest liczbą", "OK");
                }
            }
			else
			{
				DisplayAlert("Niepoprawne dane", "Pola nie mogą byc puste", "OK");
			}

		}

        private void BtnEdytujClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(entryNazwa.Text) && !string.IsNullOrEmpty(entryCena.Text) && !string.IsNullOrEmpty(entryIlosc.Text))
            {
                if (int.TryParse(entryIlosc.Text, out int _) && decimal.TryParse(entryCena.Text, out decimal _))
                {

                }
             }
            else
            {
                DisplayAlert("Niepoprawne dane", "Pola nie mogą byc puste", "OK");
            }

        }
    }
}