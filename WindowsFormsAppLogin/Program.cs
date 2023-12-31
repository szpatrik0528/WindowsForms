﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Encoders;

namespace WindowsFormsAppLogin
{
    internal static class Program
    {
        public static FormLogin formLogin = null;
        public static Form_kosarhoz formVasarlas = null;
        public static MySqlConnection connection = null;
        public static MySqlCommand command = null;
        static void Main()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "vasarlas";
            builder.CharacterSet = "utf8";
            connection = new MySqlConnection(builder.ConnectionString);
            command = connection.CreateCommand();
            try
            {
                
                connection.Open();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                Environment.Exit(0);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formLogin = new FormLogin();
            formVasarlas = new Form_kosarhoz();
            Application.Run(formLogin);
        }
    }
}
