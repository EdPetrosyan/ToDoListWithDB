using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ToDoListLibrary;

namespace ToDoListConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=RICHTOSHIBA;Initial Catalog=ToDoList;Integrated Security=True;";
            ToDoList.AddTask(connectionString,"'Help'","tbl_task");
        }
    }
}
