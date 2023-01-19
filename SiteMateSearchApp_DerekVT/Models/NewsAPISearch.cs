using System.Collections.Generic;

namespace SiteMateSearchApp_DerekVT.Models
{
	public class NewsAPISearch
	{
		public string status { get; set; }
		public int totalResults { get; set; }
		public List<Article> articles { get; set; }
	}
}