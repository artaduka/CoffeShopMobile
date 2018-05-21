using System;
using System.Collections.Generic;
using CoffeShopMobile.Models;
using Xamarin.Forms;

namespace CoffeShopMobile
{
    public partial class ItemDetailPage : ContentPage
    {
		private Item _item;
		public ItemDetailPage(Item item)
        {
			InitializeComponent();
			_item = item;
            AbsoluteLayout peakLayout = new AbsoluteLayout
            {
                HeightRequest = 250,
				BackgroundColor = Color.AliceBlue
            };

            var title = new Label
            {
				Text =  item.Name,
                FontSize = 30,
                FontFamily = "AvenirNext-DemiBold",
                TextColor = Color.White
            };

            var where = new Label
            {
                Text = "Drinks", //Item Category
                TextColor = Color.FromHex("#ddd"),
                FontFamily = "AvenirNextCondensed-Medium"
            };

            var image = new Image()
            {
                Source = ImageSource.FromFile("southmountain.jpg"), // load big image of product
                Aspect = Aspect.AspectFill,
            };

            var overlay = new BoxView()
            {
                Color = Color.Black.MultiplyAlpha(.7f)
            };



			var description = new Frame()
			{
				Padding = new Thickness(10, 5),
				HasShadow = false,
				BackgroundColor = Color.Transparent,
				Content = new Label()
				{
					FontSize = 14,
					TextColor = Color.FromHex("#ddd"),
					Text = item.Name
                }
            };

            AbsoluteLayout.SetLayoutFlags(overlay, AbsoluteLayoutFlags.All);
            AbsoluteLayout.SetLayoutBounds(overlay, new Rectangle(0, 1, 1, 0.3));

            AbsoluteLayout.SetLayoutFlags(image, AbsoluteLayoutFlags.All);
            AbsoluteLayout.SetLayoutBounds(image, new Rectangle(0f, 0f, 1f, 1f));

            AbsoluteLayout.SetLayoutFlags(title, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(title,
                new Rectangle(0.1, 0.85, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize)
            );

            AbsoluteLayout.SetLayoutFlags(where, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(where,
                new Rectangle(0.1, 0.95, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize)
            );
   

            peakLayout.Children.Add(image);
            peakLayout.Children.Add(overlay);
            peakLayout.Children.Add(title);
            peakLayout.Children.Add(where);
			var orderBtn = new Button()
            {
                Text = "Order this Item",
                HorizontalOptions = LayoutOptions.StartAndExpand
            };
			var endButtonLayout = new StackLayout()
			{
				VerticalOptions = LayoutOptions.End,
				HorizontalOptions = LayoutOptions.StartAndExpand,
				Children = 
				{
					orderBtn
				}
			};



            Content = new StackLayout()
            {
                BackgroundColor = Color.FromHex("#333"),
                Children = {
                    peakLayout,
                    description,
					endButtonLayout
                }
            };

        }
    }
}
