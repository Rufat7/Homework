using LiveCharts.Wpf.Charts.Base;
using WpfApp19.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;


namespace WpfApp19.Services.Interfaces
{
	internal interface IChartService
	{
		public void AddSerie(MyChart chart, Brush color);

	}
}
