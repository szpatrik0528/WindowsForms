using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsAppTagdij
{
    public partial class Form1 : Form
    {
        MySqlConnection connection = null;
        MySqlCommand command = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            tagokBetoltese();
        }

        private void tagokBetoltese()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder(); //kapcsolat teremtése az sql-el
            sb.Clear();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "tagdij";
            connection = new MySqlConnection(sb.ConnectionString); //kapcsolat létrehozádsa
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "SELECT `azon` ,`nev`, `szulev` ,`irszam`, `orsz` FROM ugyfel WHERE 1 ORDER BY nev;";
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Tag beolvasottTag = new Tag(dr.GetInt32("azon"), dr.GetString("nev"), dr.GetInt32("szulev"), dr.GetInt32("irszam"), dr.GetString("orsz"));
                        listBox_tagok.Items.Add(beolvasottTag);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);

            }
        }

        private void listBox_tagok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_tagok.SelectedIndex < 0)
            {
                return;
            }
            Tag kivalasztottTag = (Tag)listBox_tagok.SelectedItem;
            textBox_azon.Text = kivalasztottTag.azon.ToString();
            textBox_nev.Text = kivalasztottTag.nev.ToString();
            textBox_orsz.Text = kivalasztottTag.orsz.ToString();
            numericUpDown_irszam.Value = (decimal)kivalasztottTag.irszam;
            numericUpDown_szulev.Value = (decimal)kivalasztottTag.szulev;
        }

        private void button_update_Click(object sender, EventArgs e)
        {

        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            //-- adatellenőrzés a beviteli mezőkben 
            if (string.IsNullOrEmpty(textBox_nev.Text))
            {
                MessageBox.Show("Nincs név");
                return;
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
