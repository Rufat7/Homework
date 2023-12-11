using System;
using ProxyExample.ConcreteImplementations;
using ProxyExample.Interfaces;
using ProxyExample.Proxies;

namespace ProxyExample
{
	class Program
	{
		static void Main(string[] args)
		{
			IImageDownloader imageDownloader = new ImageDownloaderProxy(new ImageDownloader());

			imageDownloader.DownloadImage("https://example.com/image1.jpg");
			imageDownloader.DownloadImage("https://example.com/image2.jpg");

			imageDownloader.DownloadImage("https://example.com/image1.jpg");

			Console.ReadLine();
		}
	}
}
