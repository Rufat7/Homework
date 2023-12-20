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
using To_Do_List_Pattern.Factories;
using To_Do_List_Pattern.Interfaces;

namespace To_Do_List_Pattern
{
	public partial class MainWindow : Window
	{
		private readonly ITaskManagerFactory factory;

		public MainWindow()
		{
			InitializeComponent();
			factory = new WpfTaskManagerFactory();
			CreateUIElements();
		}

		private void CreateUIElements()
		{
			ITaskButton addButton = factory.CreateTaskButton();
			ITaskTextBox taskInput = factory.CreateTaskTextBox();
			ITaskListBox taskList = factory.CreateTaskListBox();

			addButton.Render();
			taskInput.Render();
			taskList.Render();
		}

		private void AddTask_Click(object sender, RoutedEventArgs e)
		{

			string newTask = taskInputTextBox.Text;

			if (!string.IsNullOrEmpty(newTask))
			{

				taskListBox.Items.Add(newTask);


				taskInputTextBox.Text = string.Empty;
			}
		}

		private void RemoveTask_Click(object sender, RoutedEventArgs e)
		{
			if (taskListBox.SelectedItem != null)
			{

				taskListBox.Items.Remove(taskListBox.SelectedItem);
			}
		}

		private void MarkCompleted_Click(object sender, RoutedEventArgs e)
		{
			if (taskListBox.SelectedItem != null)
			{
				string selectedTask = taskListBox.SelectedItem as string;

				if (!string.IsNullOrEmpty(selectedTask))
				{
					int selectedIndex = taskListBox.SelectedIndex;

					var listBoxItem = taskListBox.ItemContainerGenerator.ContainerFromIndex(selectedIndex) as ListBoxItem;
					if (listBoxItem != null)
					{
						listBoxItem.Foreground = Brushes.Green;
						listBoxItem.FontStyle = FontStyles.Italic;
					}
				}
			}
		}

	}

}
