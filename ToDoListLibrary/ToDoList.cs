using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ToDoListLibrary
{
    public class ToDoList
    {
        public static void AddTask(string task,SqlConnection connection)
        {
            using(connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=RICHTOSHIBA;Initial Catalog = ToDoList;Integrated Security=true;";
                using (SqlCommand insert = new SqlCommand($"INSERT INTO tbl_task (task) VALUES ('{task}')"))
                {
                    insert.ExecuteNonQuery();
                }
            }
        }
    }
}
