﻿using System.Net;
using System.Windows;
using System.Windows.Media.Imaging;
using CSJ2K;

namespace WP.CSJ2K.Test
{
	public partial class MainPage
	{
		// Constructor
		public MainPage()
		{
			InitializeComponent();

			// Sample code to localize the ApplicationBar
			//BuildLocalizedApplicationBar();
		}

		// Sample code for building a localized ApplicationBar
		//private void BuildLocalizedApplicationBar()
		//{
		//    // Set the page's ApplicationBar to a new instance of ApplicationBar.
		//    ApplicationBar = new ApplicationBar();

		//    // Create a new button and set the text value to the localized string from AppResources.
		//    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
		//    appBarButton.Text = AppResources.AppBarButtonText;
		//    ApplicationBar.Buttons.Add(appBarButton);

		//    // Create a new menu item with the localized string from AppResources.
		//    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
		//    ApplicationBar.MenuItems.Add(appBarMenuItem);
		//}
		private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
		{
			var request = WebRequest.Create("http://www.microimages.com/gallery/jp2/1.jp2");
			request.BeginGetResponse(ar =>
				                         {
					                         var response = request.EndGetResponse(ar);
					                         DecodedImage.Source =
						                         (WriteableBitmap)J2kImage.FromStream(response.GetResponseStream());
				                         }, null);
		}
	}
}