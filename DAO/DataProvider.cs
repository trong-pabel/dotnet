﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAO
{
    public class DataProvider
    {
        private static DataProvider _Instance;
        public static DataProvider Instance
        {
            get { if(_Instance == null) 
                    _Instance = new DataProvider();
                return DataProvider._Instance;
            }
            private set { DataProvider._Instance = value; }
        }
        private DataProvider() { }

        private string connectionSTR = @"Data Source=DESKTOP-UELNR5R\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";
        public DataTable ExecuteQuery(string query)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            return data;
        }
        public int ExecuteNonQuery(string query,object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if(parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if(item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                //DataTable data = new DataTable();
                //SqlDataAdapter adapter = new SqlDataAdapter(command);
                //adapter.Fill(data);
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }

    }
}
