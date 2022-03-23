using System;
using System.Data.SqlClient;
using System.IO;
using System.Net.Sockets;

namespace ConsoleApp5
{


    internal class Program
    {
        static void Main(string[] args)
        {
            GetSqlConnection();
        }

        static void GetSqlConnection()
        {
            string connectionString = "Data Source= {DbSourceName} ;Initial Catalog={DbName};Integrated Security=SSPI;";

            //driver, provider

            using(var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection successfully!");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

        }
    }
}

