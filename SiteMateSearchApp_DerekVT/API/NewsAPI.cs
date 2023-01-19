using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using SiteMateSearchApp_DerekVT.Models;

namespace SiteMateSearchApp_DerekVT.API
{
	public interface INewsAPI
	{
		[Get("/v2/everything")]
		Task<NewsAPISearch> GetNews(
			[Query("q")] string searchPhrase,
			[Query("from")] string from = "2023-01-19",
			[Query("sortBy")] string sortBy = "popularity",
			[Query("apiKey")] string apiKey = "f4209a2caa3241069c2bba18e07fab39");
	}
}