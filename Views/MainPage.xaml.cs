using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoffeShopMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
    {
		void Handle_Clicked_1(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new ViewOrdersPage());
		}

		

        public MainPage()
        {
            InitializeComponent();


				
        }
		void Handle_Clicked(object sender, System.EventArgs e)
           
		{
			
			Navigation.PushAsync(new OrderPage());
		}
    }
}