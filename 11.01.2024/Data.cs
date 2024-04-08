using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO;

public class Data
{
    public DataTable CreateTaskTable()
    {
        DataTable dataTable = new DataTable("Tasks");

        dataTable.Columns.Add("Id", typeof(int));
        dataTable.Columns.Add("Name", typeof(string));

        return dataTable;
    }
}
