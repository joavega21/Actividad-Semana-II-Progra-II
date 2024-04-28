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
    public partial class ejercicio4 : Form {
        public ejercicio4() {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e) {
            int cantidad = int.Parse(txtCantidad.Text);
            double precio = double.Parse(txtPrecio.Text);
            double totalN = 0, descuento = 0, total = 0;
            totalN = precio * cantidad;
            if(totalN < 20000) {
                descuento = totalN * 0.15;
                total = totalN - descuento;
                lblTotal.Text = "Total a pagar: $" + total;
            } else{
                descuento = totalN * 0.35;
                total = totalN - descuento;
                lblTotal.Text = "Total a pagar: $" + total;
            }
        }

        private void ejercicio4_Load(object sender, EventArgs e) {

        }
    }
}
