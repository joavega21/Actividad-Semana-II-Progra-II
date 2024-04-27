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
    public partial class ejercicio8 : Form {
        public ejercicio8() {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e) {
            txtTabla.Clear();
            lsbTabla.Items.Clear();
        }

        private void btnGenerar_Click(object sender, EventArgs e) {
            int num = int.Parse(txtTabla.Text);
            int producto = 0, i = 1;
            do {
                producto = num * i;
                lsbTabla.Items.Add(num + " X " + i + " = " + producto);
                i++;
            } while (i <= 10);
        }
    }
}
