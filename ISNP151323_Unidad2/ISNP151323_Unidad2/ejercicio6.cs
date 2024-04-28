using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISNP151323_Unidad2 {
    public partial class ejercicio6 : Form {
        public ejercicio6() {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e) {
            string[] unidades = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] decenas = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] centenas = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] millares = { "", "M", "MM", "MMM" };
            int num = int.Parse(txtCantidad.Text);
            if (num <= 0 && num >= 4000) {
                lblResultado.Text = "Cantidad no valida";
            } else {
                int mill = num / 1000;
                int resto = num % 1000;
                int cent = num / 100;
                resto = resto % 100;
                int dec = num / 10;
                resto = resto % 10;
                int uni = resto;
                lblResultado.Text = "Respuesta: " + millares.ElementAtOrDefault(mill) + centenas.ElementAtOrDefault(cent) + decenas.ElementAtOrDefault(dec) + unidades.ElementAtOrDefault(uni);
            }

        }

        private void ejercicio6_Load(object sender, EventArgs e) {

        }
    }
}
