using System;
using System.Data;
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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp19.Views
{

	public partial class Calculator : Window
	{
		private Stack<string> history = new Stack<string>();

		public Calculator()
		{
			InitializeComponent();




			foreach (UIElement el in MainRoot.Children)
			{
				if (el is Button)
				{
					((Button)el).Click += Button_Click;
				}
			}
		}
		private void But3_Click(object sender, RoutedEventArgs e)
		{
			var uri = new Uri(@"Dictionary3.xaml", UriKind.Relative);
			ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
			Application.Current.Resources.Clear();
			Application.Current.Resources.MergedDictionaries.Add(resourceDict);
		}
		private void But4_Click(object sender, RoutedEventArgs e)
		{

			var uri = new Uri(@"Dictionary4.xaml", UriKind.Relative);
			ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
			Application.Current.Resources.Clear();
			Application.Current.Resources.MergedDictionaries.Add(resourceDict);

		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			string str = (string)((Button)e.OriginalSource).Content;

			if (str == "AC")
			{
				textLabel.Text = "";
				history.Clear();
			}
			else if (str == "=")
			{
				string value = new DataTable().Compute(textLabel.Text, null).ToString();
				textLabel.Text = value;
				history.Push(textLabel.Text);
			}



			else if (str == "Add")
			{

			}
			else if (str == "Back")
			{
				this.Close();
			}

			else if (str == "Backspace")
			{
		
				if (textLabel.Text.Length > 0)
				{
					textLabel.Text = textLabel.Text.Remove(textLabel.Text.Length - 1);
				}
			}
			else
			{
				textLabel.Text += str;
			}

		}

	}
	
}