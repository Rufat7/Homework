using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Monefy.Views;


public partial class InfoView : UserControl
{
	private bool isMenuOpen = false;
	public InfoView()
    {
        InitializeComponent();
		Loaded += MainWindow_Loaded;
	}
	private void MainWindow_Loaded(object sender, RoutedEventArgs e)
	{

		dateTextBlock.FontFamily = new System.Windows.Media.FontFamily("Arial");
		dateTextBlock.Foreground = System.Windows.Media.Brushes.DimGray;

		timeTextBlock.FontFamily = new System.Windows.Media.FontFamily("Arial");
		timeTextBlock.Foreground = System.Windows.Media.Brushes.DimGray;


		dateTextBlock.Text = DateTime.Now.ToString("D");
		timeTextBlock.Text = DateTime.Now.ToString("T");
	}




private void ButtonMenu_Click(object sender, RoutedEventArgs e)
	{
		if (isMenuOpen)
		{

			

			Storyboard sb = FindResource("CloseMenu") as Storyboard;
			sb.Begin();

			isMenuOpen = false;
		}
		else
		{
			

			Storyboard sb = FindResource("OpenMenu") as Storyboard;
			sb.Begin();

			isMenuOpen = true;
		}
	
	}
}
