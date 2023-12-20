﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List_Pattern.Interfaces
{
	public interface ITaskManagerFactory
	{
		ITaskButton CreateTaskButton();
		ITaskTextBox CreateTaskTextBox();
		ITaskListBox CreateTaskListBox();
	}
}
