using System;
using System.Collections.Generic;
using ProxyExample.Interfaces;

namespace ProxyExample.Proxies
{
	public class ImageDownloaderProxy : IImageDownloader
	{
		private IImageDownloader imageDownloader;
		private HashSet<string> cachedImages;

		public ImageDownloaderProxy(IImageDownloader downloader)
		{
			imageDownloader = downloader;
			cachedImages = new HashSet<string>();
		}

		public void DownloadImage(string url)
		{
			if (cachedImages.Contains(url))
			{
				Console.WriteLine($"Фотка {url} скачан из кеша");
			}
			else
			{
				imageDownloader.DownloadImage(url);
				cachedImages.Add(url);
			}
		}
	}
}

