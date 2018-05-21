using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CoffeShopMobile.Models;
using CoffeShopMobile.RestClient;
using Xamarin.Forms;

namespace CoffeShopMobile
{
    public partial class OrderPage : ContentPage
    {
		private RestClientService<ItemCategories> restClient;
		public OrderPage()
        {
            InitializeComponent();

			restClient = new RestClientService<ItemCategories>();

			InitializeListView();
			lstItemCategories.ItemSelected += ItemsCategory_ItemSelected;
        }

		private void ItemsCategory_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var selectedItem = e.SelectedItem as ItemCategories;
			Navigation.PushAsync(new ItemSelectionPage(selectedItem));
		}

		private async void InitializeListView()
		{
			lstItemCategories.ItemsSource =  await loadData();
		}
		private async Task<List<ItemCategories>> loadData()
		{
			var result = await restClient.GetAsync("getItemCategories");
			return result;
		}
	}
}
