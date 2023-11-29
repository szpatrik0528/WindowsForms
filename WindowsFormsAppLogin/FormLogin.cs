using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace WindowsFormsAppLogin
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            Program.command.CommandText = "SELECT vasarlo.jelszo FROM vasarlo WHERE vasarlo.nev=@nev;";
            Program.command.Parameters.Clear();
            Program.command.Parameters.AddWithValue("@nev", textBox_nev.Text);
            MySqlDataReader reader = Program.command.ExecuteReader();
            if(reader.Read())
            {
                string taroltJelszo = reader.GetString("jelszo");
                if(taroltJelszo.Equals(textBox_pass.Text))
                {
                    reader.Close();
                    Program.formVasarlas.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("nem jó");
                }
            }
        }
    }
}
