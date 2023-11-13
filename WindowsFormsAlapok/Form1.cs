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

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_miminumvagymaximum.SelectedIndex = 0;
        }

        private void button_kereses_Click(object sender, EventArgs e)
        {

        }

        private void button_betoltes_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "vesszővel tagolt csv |*.csv| txt file (*.txt) All files (*.*) | *.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.Title = "Adatfálj neve";
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
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

        private void button_kiiras_Click(object sender, EventArgs e)
        {

        }

        private void button_megszamolas_Click(object sender, EventArgs e)
        {

        }

        private void button_maximumvagyminimum_Click(object sender, EventArgs e)
        {

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
    }
}
