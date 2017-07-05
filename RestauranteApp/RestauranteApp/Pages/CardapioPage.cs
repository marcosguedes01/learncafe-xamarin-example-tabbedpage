using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace RestauranteApp.Pages
{
    public class CardapioPage : BasePage
    {
        public CardapioPage()
        {
            Title = "Cardápio";

            var lista = new ListView();
            lista.ItemsSource = new[] {
                "Almoço",
                "Jantar",
                "Pizzas",
                "Sanduiches"
            };

            lista.ItemTapped += (sender, e) =>
            {
                var item = ((ListView)sender).SelectedItem as string;

                ((ListView)sender).SelectedItem = null;

                DisplayAlert(Title, item, "OK");
            };

            Content = lista;
        }
    }
}