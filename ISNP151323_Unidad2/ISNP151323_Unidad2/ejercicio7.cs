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
    public partial class ejercicio7 : Form {
        public ejercicio7() {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e) {
            int suma = 0, i = 1;
            while(i <= 100) {
                suma = suma + i;
                lsbLista.Items.Add(i);
                i++;
            }
            lblResultado.Text = "El resultado de la suma es: " + suma;
        }

        private void ejercicio7_Load(object sender, EventArgs e) {

        }
    }
}
