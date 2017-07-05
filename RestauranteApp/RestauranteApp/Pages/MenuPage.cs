using RestauranteApp.Controls;

namespace RestauranteApp.Pages
{
    public class MenuPage : CustomTabbedPage
    {
        public MenuPage()
        {
            Title = "Menu";

            Children.Add(new IndexPage { Title = "Início", Icon = "home.png" });
            Children.Add(new CardapioPage { Title = "Cardápio", Icon = "restaurant.png" });
            Children.Add(new MapaPage { Title = "Mapa", Icon = "location.png" });
        }
    }
}