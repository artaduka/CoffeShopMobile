using System;
using System.Collections.Generic;

namespace CoffeShopMobile.Models
{
    public class ItemCategories
    {
		public string Name { get; set; }
        public int Id { get; set; }
        public string ImageUrl { get; set; }
		public ICollection<Item> Items
		{
			get;
			set;
		}
    }
}
