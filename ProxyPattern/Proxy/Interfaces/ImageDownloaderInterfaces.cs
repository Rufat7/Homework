using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyExample.Interfaces
{
	public interface IImageDownloader
	{
		void DownloadImage(string url);
	}
}
