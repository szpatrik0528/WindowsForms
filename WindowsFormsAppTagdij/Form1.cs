﻿using System;
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
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder(); //kapcsolat teremtése az sql-el
            sb.Clear();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "tagdij";
            connection = new MySqlConnection(sb.ConnectionString); //kapcsolat létrehozádsa
            command = connection.CreateCommand();
            tagokBetoltese();
        }

        private void tagokBetoltese()
        {
            listBox_tagok.Items.Clear();
            try
            {
                if (connection.State != ConnectionState.Open) 
                {
                    connection.Open();
                }
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
            if (listBox_tagok.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott Tag!");
                return;
            }

            if (string.IsNullOrEmpty(textBox_nev.Text) || string.IsNullOrEmpty(textBox_orsz.Text))
            {
                MessageBox.Show("Minden mezőt ki kell tölteni!");
                return;
            }

            Tag kivalasztottTag = (Tag)listBox_tagok.SelectedItem;

            // Frissítsd az adatokat a kiválasztott Tag objektumban
            kivalasztottTag.nev = textBox_nev.Text;
            kivalasztottTag.orsz = textBox_orsz.Text;
            kivalasztottTag.irszam = (int)numericUpDown_irszam.Value;
            kivalasztottTag.szulev = (int)numericUpDown_szulev.Value;

            listBox_tagok.Items[listBox_tagok.SelectedIndex] = kivalasztottTag;
            textBox_azon.Text = "";
            textBox_nev.Text = "";
            textBox_orsz.Text = "";
            numericUpDown_irszam.Value = numericUpDown_irszam.Minimum;
            numericUpDown_szulev.Value = numericUpDown_szulev.Minimum;
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            //-- adatellenőrzés a beviteli mezőkben 
            if (string.IsNullOrEmpty(textBox_nev.Text))
            {
                MessageBox.Show("Nincs név");
                return;
            }
            string nev= textBox_nev.Text;
            decimal szulev = (decimal)numericUpDown_szulev.Value;
            decimal irszam = (decimal)numericUpDown_irszam.Value;
            string orsz = textBox_orsz.Text;
            command.CommandText = "INSERT INTO `ugyfel`(`azon`, `nev`, `szulev`, `irszam`, `orsz`) VALUES (NULL, @nev, @szulev, @irszam, @orsz)";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nev", nev);
            command.Parameters.AddWithValue("@szulev", szulev);
            command.Parameters.AddWithValue("@irszam", irszam);
            command.Parameters.AddWithValue("@orsz", orsz);
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command.ExecuteNonQuery();
                MessageBox.Show("Sikeres rögzítés!");
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }
            textBox_nev.Text = "";
            numericUpDown_szulev.Value = numericUpDown_szulev.Minimum;
            numericUpDown_irszam.Value = numericUpDown_irszam.Minimum;
            textBox_orsz.Text = "H";
            tagokBetoltese();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (listBox_tagok.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott Tag!");
                return;
            }

            Tag kivalasztottTag = (Tag)listBox_tagok.SelectedItem;

            // Töröld az adott Tag-ot a listából
            listBox_tagok.Items.Remove(kivalasztottTag);
            textBox_azon.Text = "";
            textBox_nev.Text = "";
            textBox_orsz.Text = "";
            numericUpDown_irszam.Value = numericUpDown_irszam.Minimum;
            numericUpDown_szulev.Value = numericUpDown_szulev.Minimum;

        }
    }
}
