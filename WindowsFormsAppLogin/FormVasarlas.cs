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
    public partial class FormVasarlas : Form
    {
        MySqlConnection connection = null;
        MySqlCommand command = null;

        public string kivalasztottTermek { get; private set; }

        public FormVasarlas()
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

        private void button_vasarlas_Click(object sender, EventArgs e)
        {
            if (listBox_termek.SelectedIndex < 0)
            {
                return;
            }
            Termek kivalasztottTermek = (Termek)listBox_termek.SelectedItem;

            string kosarElem = $"{kivalasztottTermek.termeknev} - {kivalasztottTermek.db} - {kivalasztottTermek.ar} Ft/db";
            listBox_kosar.Items.Add(kosarElem);
        }

        private void textBox_vegosszeg_TextChanged(object sender, EventArgs e)
        {
            decimal total = 0;

            foreach (var item in listBox_kosar.Items)
            {
                string[] parts = item.ToString().Split('-');
                if (parts.Length >= 3)
                {
                    decimal price = decimal.Parse(parts[2].Trim().Replace("Ft/db", ""));
                    total += price;
                }
            }
            textBox_vegosszeg.Text = total.ToString("F2") + " Ft";
        }
    }
}
