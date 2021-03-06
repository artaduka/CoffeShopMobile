﻿using System;
using System.Collections;

namespace CoffeShopMobile.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
		public string Barcode { get; set; }
		public string Name { get;set;}
		public int ItemCategoryId { get; set; }
        public string ImageUrl
		{
			get;
			set;
		}

		public ItemCategories ItemCategory
        {
            get;
            set;
        }

    }
}