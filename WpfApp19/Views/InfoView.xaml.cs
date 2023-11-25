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
using WpfApp19.ViewModels;

namespace WpfApp19.Views
{

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
			dateTextBlock.Foreground = System.Windows.Media.Brushes.Black;

			timeTextBlock.FontFamily = new System.Windows.Media.FontFamily("Arial");
			timeTextBlock.Foreground = System.Windows.Media.Brushes.Black;


			dateTextBlock.Text = DateTime.Now.ToString("D");
			timeTextBlock.Text = DateTime.Now.ToString("T");
		}
		private void But1_Click(object sender, RoutedEventArgs e)
		{
			var uri = new Uri(@"Dictionary1.xaml", UriKind.Relative);
			ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
			Application.Current.Resources.Clear();
			Application.Current.Resources.MergedDictionaries.Add(resourceDict);
		}
		private void But2_Click(object sender, RoutedEventArgs e)
		{

			var uri = new Uri(@"Dictionary2.xaml", UriKind.Relative);
			ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
			Application.Current.Resources.Clear();
			Application.Current.Resources.MergedDictionaries.Add(resourceDict);

		}


		private void Add_Click(object sender, RoutedEventArgs e)

		{
			Calculator calculator = new Calculator();
			calculator.Show();

		}
		private void Minus_Click(object sender, RoutedEventArgs e)

		{
			Calculator calculator = new Calculator();
			calculator.Show();

		}
		private void Tooth_Click(object sender, RoutedEventArgs e)

		{
			Calculator calculator = new Calculator();
			calculator.Show();

		}
		private void Home_Click(object sender, RoutedEventArgs e)

		{
			Calculator calculator = new Calculator();
			calculator.Show();

		}
		private void Cat_Click(object sender, RoutedEventArgs e)

		{
			Calculator calculator = new Calculator();
			calculator.Show();

		}
		private void Car_Click(object sender, RoutedEventArgs e)

		{
			Calculator calculator = new Calculator();
			calculator.Show();

		}
		private void Taxi_Click(object sender, RoutedEventArgs e)

		{
			Calculator calculator = new Calculator();
			calculator.Show();

		}
		private void Food_Click(object sender, RoutedEventArgs e)

		{
			Calculator calculator = new Calculator();
			calculator.Show();

		}
		private void ClothesHanger_Click(object sender, RoutedEventArgs e)

		{
			Calculator calculator = new Calculator();
			calculator.Show();

		}
		private void Temperature_Click(object sender, RoutedEventArgs e)

		{
			Calculator calculator = new Calculator();
			calculator.Show();

		}
		private void Dumbbell_Click(object sender, RoutedEventArgs e)

		{
			Calculator calculator = new Calculator();
			calculator.Show();

		}
		private void Bus_Click(object sender, RoutedEventArgs e)

		{
			Calculator calculator = new Calculator();
			calculator.Show();

		}
		private void Phone_Click(object sender, RoutedEventArgs e)

		{
			Calculator calculator = new Calculator();
			calculator.Show();

		}
		private void Gift_Click(object sender, RoutedEventArgs e)

		{
			Calculator calculator = new Calculator();
			calculator.Show();
		}
		private void ButtonMenu_Click(object sender, RoutedEventArgs e)
		{
			if (isMenuOpen)
			{

				ButtonMenu.SetResourceReference(StyleProperty, "OpenBtn");

				Storyboard sb = FindResource("CloseMenu") as Storyboard;
				sb.Begin();

				isMenuOpen = false;
			}
			else
			{
				ButtonMenu.SetResourceReference(StyleProperty, "CloseBtn");

				Storyboard sb = FindResource("OpenMenu") as Storyboard;
				sb.Begin();

				isMenuOpen = true;
			}
		}
	}
}
