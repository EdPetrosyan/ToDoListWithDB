﻿using System;
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
        public static void AddTask(string connectionString, string values,string tblName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand insert = new SqlCommand($"INSERT INTO {tblName} VALUES ('{values}')", connection))
                    {
                        insert.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public static DataTable ReciveTasks(string connectionString, string tblName)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand select = new SqlCommand($"SELECT * FROM {tblName}",connection))
                    {
                        SqlDataReader reader = select.ExecuteReader(CommandBehavior.CloseConnection);
                        dt.Load(reader);
                    }
                }
                return dt;
            }
            catch (SqlException)
            {
                throw;
            }
        }

    }
}
