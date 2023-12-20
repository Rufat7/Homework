using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List_Pattern.Factories
{
	using To_Do_List_Pattern.Interfaces;
	

	public class WpfTaskManagerFactory : ITaskManagerFactory
	{
		public ITaskButton CreateTaskButton()
		{
			return new WpfTaskButton();
		}

		public ITaskTextBox CreateTaskTextBox()
		{
			return new WpfTaskTextBox();
		}

		public ITaskListBox CreateTaskListBox()
		{
			return new WpfTaskListBox();
		}
	}
}

