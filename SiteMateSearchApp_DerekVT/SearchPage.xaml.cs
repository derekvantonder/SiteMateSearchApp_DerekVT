using System;
using System.Net.Http;
using Newtonsoft.Json;
using SiteMateSearchApp_DerekVT.Models;
using Xamarin.Forms;

namespace SiteMateSearchApp_DerekVT
{
	public partial class SearchPage : ContentPage
	{
		public SearchPage()
		{
			InitializeComponent();
		}

		private async void SearchButton_OnClicked(object sender, EventArgs e)
		{
			// API is sadly returning a 400 Bad Request and I don't have time to debug it :(
			// "https://newsapi.org/v2/everything?q=EntrySearchPhrase&from=2023-01-19&sortBy=popularity&apiKey=f4209a2caa3241069c2bba18e07fab39"
			//var newsApi = RestService.For<INewsAPI>("https://newsapi.org");
			//var news = await newsApi.GetNews(EntrySearchPhrase.Text);
			
			
			//NewsAPISearch newsApiSearchMock = new NewsAPISearch { new List<Article};
			
			using (var client = new HttpClient())
			{
				var response = await client.GetAsync($"https://newsapi.org/v2/everything?q={EntrySearchPhrase.Text}&from=2023-01-19&sortBy=popularity&apiKey=f4209a2caa3241069c2bba18e07fab39");
				var responseString = await response.Content.ReadAsStringAsync();
				Console.WriteLine(responseString);
				
				// Convert the JSON string into an instance of the NewsAPISearch class
				var news = JsonConvert.DeserializeObject<NewsAPISearch>(responseString);
				BindingContext = news;
			}
			
		}
	}
}