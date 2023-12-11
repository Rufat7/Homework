using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProxyExample.Interfaces;

namespace ProxyExample.ConcreteImplementations
{
	public class ImageDownloader : IImageDownloader
	{
		public void DownloadImage(string url)
		{
			Console.WriteLine($"Изображение скачано с: {url}");
		}
	}
}

