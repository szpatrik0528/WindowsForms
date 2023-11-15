using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_winForm
{
    internal class Pizza
    {
        int pazon;
        string pnev;
        double par;

        public Pizza(string line)
        {
            string[] sor = line.Split(';');
            pazon = int.Parse(sor[0]);
            pnev = sor[1].Trim().Replace("\"", string.Empty);
            par = double.Parse(sor[2].Trim().Replace("\"", string.Empty).Replace('.',','));
        }

        public double Par { get => par; set => par = value; }
        public string Pnev { get => pnev; set => pnev = value; }
        public int Pazon { get => pazon; set => pazon = value; }

        public override string ToString()
        {
            return $"{pnev}, ára: {par.ToString("#0 Ft")}";
        }
    }
}
