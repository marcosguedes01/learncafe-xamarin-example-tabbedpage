using RestauranteApp.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace RestauranteApp.Pages
{
    public class MapaPage : BasePage
    {
        public MapaPage()
        {
            var posicao = new Position(-8.047562, -34.876964);

            var mapa = new Map(MapSpan.FromCenterAndRadius(posicao, Distance.FromKilometers(0.3f)))
            {
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            mapa.Pins.Add(new Pin
            {
                Type = PinType.Place,
                Position = posicao,
                Label = "Restaurante GP",
                Address = "Recife, PE"
            });

            Content = new StackLayout
            {
                Children = { mapa }
            };
        }
    }
}