using System;

using Xamarin.Forms;

namespace CoffeShopMobile
{
    public class ViewOrdersPage : ContentPage
    {
        public ViewOrdersPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

