using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace RestauranteApp.Pages
{
    public class IndexPage : BasePage
    {
        public IndexPage()
        {
            var telefone = new Button
            {
                Text = "(00) 0000-0000"
            };

            telefone.Clicked += (sender, e) => Device.OpenUri(new Uri("tel://0000000000"));

            Content = new ContentView
            {
                Content = new StackLayout
                {
                    Children = {
                        new Image{
                            Aspect = Aspect.AspectFit,
                            Source = ImageSource.FromFile("logo.png")
                        },

                        telefone
                    }
                },

                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            
        }
    }
}