using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppLogin
{
    public partial class Form_kosarhoz : Form
    {
        MySqlConnection connection = null;
        MySqlCommand command = null;

        public string kivalasztottTermek { get; private set; }

        public Form_kosarhoz()
        {
            InitializeComponent();
        }


        private void FormVasarlas_Load(object sender, EventArgs e)
        {
            termekekBetoltese();
        }

        private void termekekBetoltese()
        {
            listBox_termek.Items.Clear();
            try
            {
                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }
                Program.command.CommandText = "SELECT `termekid`, `termeknev`, `ar`, `db` FROM `termek` WHERE 1 ORDER BY termeknev";
                using (MySqlDataReader dr = Program.command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Termek beolvasottTermek = new Termek(dr.GetInt32("termekid"), dr.GetString("termeknev"), dr.GetInt32("ar"), dr.GetInt32("db"));
                        listBox_termek.Items.Add(beolvasottTermek);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "bunko");
                Environment.Exit(0);
            }
        }
        private void listBox_termek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_termek.SelectedIndex < 0)
            {
                return;
            }
            Termek kivalasztottTermek = (Termek)listBox_termek.SelectedItem;
            textBox_termeknev.Text = kivalasztottTermek.termeknev.ToString();
            numericUpDown_ar.Value = (decimal)kivalasztottTermek.ar;
            numericUpDown_db.Value = (decimal)kivalasztottTermek.db;
        }

        private void textBox_vegosszeg_TextChanged(object sender, EventArgs e)
        {
            decimal vegosszeg = 0;

            foreach (string kosarElem in listBox_kosar.Items)
            {
                int indexOfAr = kosarElem.LastIndexOf('-') + 1;
                int indexOfFt = kosarElem.IndexOf("Ft");
                string arSzoveg = kosarElem.Substring(indexOfAr, indexOfFt - indexOfAr).Trim();

                if (decimal.TryParse(arSzoveg, out decimal ar))
                {
                    vegosszeg += ar;
                }
            }

            textBox_vegosszeg.Text = vegosszeg.ToString("F"); 
        }

        private void textBox_db_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            listBox_kosar.Items.Clear();
        }

        private void listBox_kosar_SelectedIndexChanged(object sender, EventArgs e)
        {
            SzamolVegosszeg();
        }

        private void SzamolVegosszeg()
        {
            decimal vegosszeg = 0;

            foreach (string kosarElem in listBox_kosar.Items)
            {
                int indexOfAr = kosarElem.LastIndexOf('-') + 1;
                int indexOfFt = kosarElem.IndexOf("Ft");
                string arSzoveg = kosarElem.Substring(indexOfAr, indexOfFt - indexOfAr).Trim();

                if (decimal.TryParse(arSzoveg, out decimal ar))
                {
                    vegosszeg += ar;
                }
            }

            textBox_vegosszeg.Text = vegosszeg.ToString("F"); 
        }
    }
}
