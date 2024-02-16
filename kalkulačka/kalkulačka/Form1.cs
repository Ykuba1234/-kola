using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulačka
{
    public partial class kalkulačka : Form
    {
        public kalkulačka()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;

        }
        private void vypocitejButton_Click(object sender, EventArgs e)
        {
            // příprava proměnných
            string operace = comboBox1.SelectedItem.ToString();
            double cislo1 = Convert.ToDouble(numericUpDown2.Value);
            double cislo2 = Convert.ToDouble(numericUpDown1.Value);
            double vysledek = 0;

            // výpočet
            if (operace == "+")
                vysledek = cislo1 + cislo2;
            else if (operace == "-")
                vysledek = cislo1 - cislo2;
            else if (operace == "*")
                vysledek = cislo1 * cislo2;
            else if (operace == "/")
            {
                if (cislo2 != 0)
                    vysledek = cislo1 / cislo2;
                else
                    MessageBox.Show("Nulou nelze dělit");
            }
            výsledek_label.Text = vysledek.ToString();
        }
    }
}
