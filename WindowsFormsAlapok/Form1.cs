using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsAlapok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_miminumvagymaximum.SelectedIndex = 0;
            Adatbetoltes();
        }

        private void Adatbetoltes()
        {
            openFileDialog1.Filter = "vesszővel tagolt csv |*.csv| txt file (*.txt) All files (*.*) | *.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.Title = "Adatfálj neve";
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "orszagok.csv";
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        listBox_Orszagoklista.Items.Add(new Orszag(sr.ReadLine()));
                    }
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_miminumvagymaximum.SelectedIndex = 0;
        }
        

        private void button_betoltes_Click(object sender, EventArgs e)
        {
            Adatbetoltes();
        }

        private void button_kiiras_Click(object sender, EventArgs e)
        {
            FileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Valami szöveg a felhasználónak|*.txt";
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog.FileName = "eredmeny.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string eredmenyFajl = saveFileDialog.FileName;
                textBox_eredemnyfaljneve.Text = Path.GetFileName(eredmenyFajl);
                try
                {
                    using (StreamWriter sw = new StreamWriter(eredmenyFajl))
                    {
                        sw.WriteLine("Ez az eredmény!");
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Valami nem ok!"+Environment.NewLine+ex.Message);

                    throw;
                }
            }
        }

        private void button_megszamolas_Click(object sender, EventArgs e)
        {
            if (radioButton_legfeljebb.Checked)
            {
                SzamollegfeljebbSzazezer();
            }
            else
            {
                SzamolSzazezerFelett();
            }
        }

        private void SzamolSzazezerFelett()
        {
            int db = 0;
            foreach (Orszag item in listBox_Orszagoklista.Items)
            {
                if (item.Terulet > 100000)
                {
                    db++;
                }
            }
            MessageBox.Show($"Minimum 100.000 = {db}", "Minimum 100.000", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void SzamollegfeljebbSzazezer()
        {
            int db = 0;
            foreach (Orszag item in listBox_Orszagoklista.Items)
            {
                if (item.Terulet <= 100000)
                {
                    db++;
                }
            }
            MessageBox.Show($"Maximum 100.000 = {db}", "Maximum 100.000", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button_maximumvagyminimum_Click(object sender, EventArgs e)
        {
            //--Listboxban vagy a legnagyobb vagy a legkisebb területű országot válassza ki
            
            if (comboBox_miminumvagymaximum.SelectedIndex==0)
            {
                Orszag keresettOrszag = null;
                double keresettErtek = ((Orszag)listBox_Orszagoklista.Items[0]).Terulet;
                foreach (Orszag item in listBox_Orszagoklista.Items)
                {
                    if(keresettErtek > item.Terulet)
                    {
                        keresettErtek = item.Terulet;
                        keresettOrszag = item;
                    }
                }
                MessageBox.Show($"Minimum {keresettOrszag.OrszagNev} teruülete: {keresettOrszag.Terulet}");
            }
            else
            {
                foreach (Orszag item in listBox_Orszagoklista.Items)
                {
                }
            }
        }

        private void radioButton_legfeljebb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_talaltokkijelolese_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox_Orszagoklista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_eredemnyfaljneve_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_forrasfaljneve_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_teruletatlag_Click(object sender, EventArgs e)
        {
            Atlagszamitas2();
            
        }

        private void Atlagszamitas2()
        {
            double atlag = listBox_Orszagoklista.Items.Cast<Orszag>().ToList().Average(a => a.Terulet);
        }

        private void Atlagszamitas()
        {
            double atlag = 0;
            foreach (Orszag item in listBox_Orszagoklista.Items)
            {
                atlag += item.Terulet;
            }
            atlag = atlag / listBox_Orszagoklista.Items.Count;

            MessageBox.Show($"Az országok átlaga: {atlag.ToString("#,##0.00")}", "Az országok átlaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_kereses_Click(object sender, EventArgs e)
        {
            string keresiazorszagot = listBox_Orszagoklista.Text.ToLower();
        }

        private void textBox_orszagokkeresese_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
