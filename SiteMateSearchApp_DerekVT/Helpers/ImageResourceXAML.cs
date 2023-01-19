using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SiteMateSearchApp_DerekVT.Helpers
{
	[ContentProperty(nameof(Source))]
	public class ImageResourceXAML : IMarkupExtension
	{
		public string Source { get; set; }

		public object ProvideValue(IServiceProvider serviceProvider)
		{
			if (Source == null)
			{
				return null;
			}

			// Do your translation lookup here, using whatever method you require
			var imageSource = ImageSource.FromResource(
				Source, 
				typeof(ImageResourceXAML).GetTypeInfo().Assembly);

			return imageSource;
		}
	}
}