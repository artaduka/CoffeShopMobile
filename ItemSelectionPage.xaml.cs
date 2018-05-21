using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CoffeShopMobile.Models;
using Xamarin.Forms;

namespace CoffeShopMobile
{
	public partial class ItemSelectionPage : ContentPage
	{
		void Items_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as Item;
			Navigation.PushAsync(new ItemDetailPage(item));

		}


		private ItemCategories _category;
		public ItemSelectionPage(ItemCategories category)
		{
			InitializeComponent();
			_category = category;
			LoadData(_category);
		}

  //      private async Task<List<Item>> getItemsFromCloud()
		//{
		//	var e = new Task<List<Item>>();
		//	return e;
		//}

		private void LoadData(ItemCategories category)
		{
            
            //Get Items by category from webservice ..
            
			lstItems.ItemsSource = new List<Item>()
			{
                
              
				new Item()
				{
					Description = "Sugar, ....",
					Name = "Coca Cola",
					ImageUrl = "http://www.coliseumfdl.com/system/event_photos/5233/thumb/9f52bc26086a37ee606c.jpg"
				},
				new Item()
				{
					Description = "Coca Cola",
					Name = "",
					ImageUrl = "https://yt3.ggpht.com/-vgqJQOa3yGY/AAAAAAAAAAI/AAAAAAAAAAA/A0PL36_jyRE/s100-mo-c-c0xffffffff-rj-k-no/photo.jpg"
				},
				new Item()
				{
					Description = "Fanta",
					Name = "Deserts",
					ImageUrl ="https://static.thumbtackstatic.com/pictures/23410/32cbcfasamoitjos2h8jnsfdb1_100.jpg"
				}
			};

			lstItems.ItemSelected += Items_ItemSelected;

		}
	}
}
