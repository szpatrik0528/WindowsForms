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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Vesszővel tagolt CSV |*.csv|Szöveges fájl (*.txt)|*.txt|Összes fájl (*.*)|*.*";
            openFileDialog.FilterIndex = 0;
            openFileDialog.Title = "Adatfájl neve";
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.FileName = "orszagok.csv";

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Beállítjuk a betöltött fájl nevét a textBox_forrasfaljneve-be
                textBox_forrasfaljneve.Text = Path.GetFileName(openFileDialog.FileName);

                using (StreamReader sr = new StreamReader(openFileDialog.FileName))
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
            
        }
        

        private void button_betoltes_Click(object sender, EventArgs e)
        {
            Adatbetoltes();
        }   

        private void button_kiiras_Click(object sender, EventArgs e)
{
            FileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Szöveges fájl|*.txt";
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
                if (radioButton_legfeljebb.Checked)
                {
                    // A "legfeljebb" lekérdezés eredménye
                    int db = 0;
                    foreach (Orszag orszag in listBox_Orszagoklista.Items)
                    {
                        if (orszag.Terulet <= 100000)
                        {
                            sw.WriteLine($"{orszag.OrszagNev}: {orszag.Terulet} km²");
                            db++;
                        }
                    }
                    sw.WriteLine($"Összesen {db} ország van, amelynek területe legfeljebb 100.000 km².");
                }
                else
                {
                    // A "nagyobb" lekérdezés eredménye
                    int db = 0;
                    foreach (Orszag orszag in listBox_Orszagoklista.Items)
                    {
                        if (orszag.Terulet > 100000)
                        {
                            sw.WriteLine($"{orszag.OrszagNev}: {orszag.Terulet} km²");
                            db++;
                        }
                    }
                    sw.WriteLine($"Összesen {db} ország van, amelynek területe nagyobb mint 100.000 km².");
                }
            }

            MessageBox.Show("Az eredmények sikeresen mentve lettek.", "Mentés", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (IOException ex)
        {
            MessageBox.Show("Hiba történt a fájl mentése során." + Environment.NewLine + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}



        private void button_megszamolas_Click(object sender, EventArgs e)
        {
            if (listBox_Orszagoklista.SelectedItem != null)
            {
                Orszag kivalasztottOrszag = (Orszag)listBox_Orszagoklista.SelectedItem;
                bool nagyobbTerulet = kivalasztottOrszag.Terulet > 100000;

                MessageBox.Show($"{kivalasztottOrszag.OrszagNev} {(nagyobbTerulet ? "nagyobb" : "legfeljebb")} 100.000 területű.",
                                nagyobbTerulet ? "Nagyobb terület" : "Legfeljebb 100.000 terület",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nincs kijelölt ország.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (comboBox_miminumvagymaximum.SelectedIndex == 0)
            {
                Orszag keresettOrszag = null;
                double keresettErtek = ((Orszag)listBox_Orszagoklista.Items[0]).Terulet;
                int keresettIndex = 0;

                for (int i = 0; i < listBox_Orszagoklista.Items.Count; i++)
                {
                    Orszag item = (Orszag)listBox_Orszagoklista.Items[i];

                    if (keresettErtek > item.Terulet)
                    {
                        keresettErtek = item.Terulet;
                        keresettOrszag = item;
                        keresettIndex = i;
                    }
                }

                MessageBox.Show($"Minimum {keresettOrszag.OrszagNev} területe: {keresettOrszag.Terulet}");

                // Jelöld ki a keresett országot a listBox-ban
                listBox_Orszagoklista.SelectedIndex = keresettIndex;
            }
            else
            {
                Orszag keresettOrszag = null;
                double keresettErtek = ((Orszag)listBox_Orszagoklista.Items[0]).Terulet;
                int keresettIndex = 0;

                for (int i = 0; i < listBox_Orszagoklista.Items.Count; i++)
                {
                    Orszag item = (Orszag)listBox_Orszagoklista.Items[i];

                    if (keresettErtek < item.Terulet)
                    {
                        keresettErtek = item.Terulet;
                        keresettOrszag = item;
                        keresettIndex = i;
                    }
                }

                MessageBox.Show($"Maximum {keresettOrszag.OrszagNev} területe: {keresettOrszag.Terulet}");

                // Jelöld ki a keresett országot a listBox-ban
                listBox_Orszagoklista.SelectedIndex = keresettIndex;
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
            // Az input szöveget kisbetűsre alakítjuk a pontos egyezés érdekében
            string keresiazorszagot = textBox_orszagokkeresese.Text.ToLower();

            // Keresés a listBox-ban
            for (int i = 0; i < listBox_Orszagoklista.Items.Count; i++)
            {
                Orszag orszag = (Orszag)listBox_Orszagoklista.Items[i];

                // Az ország nevét kisbetűsre alakítjuk a kisbetű-nagybetű különbség figyelmen kívül hagyása érdekében
                if (orszag.OrszagNev.ToLower() == keresiazorszagot)
                {
                    // Megtaláltuk az országot, jelöljük ki, és kilépünk a ciklusból
                    listBox_Orszagoklista.SelectedIndex = i;
                    return;
                }
            }

            // Ha az ország nem található, kiírhatunk egy üzenetet vagy kezelhetjük másképp a helyzetet
            MessageBox.Show("Az adott ország nem található a listában.");
        }

        private void textBox_orszagokkeresese_TextChanged(object sender, EventArgs e)
        {
            // Itt akár további keresési funkciókat is hozzáadhatnál, ha szükséges
        }

    }
}
