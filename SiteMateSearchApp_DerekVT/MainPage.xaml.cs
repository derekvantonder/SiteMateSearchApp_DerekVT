using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SiteMateSearchApp_DerekVT
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		// NOTE: In the interest of time, we are not using a Command here as we would normally do
		private async void StartSearchButton_OnClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new SearchPage());
		}
	}
}