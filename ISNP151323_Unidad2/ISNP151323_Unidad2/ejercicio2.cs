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
    public partial class ejercicio2 : Form {
        convertir objConversor = new convertir();
        public ejercicio2() {
            InitializeComponent();
        }

        private void ejercicio2_Load(object sender, EventArgs e) {
            cboTipo.SelectedIndex = 0;
            AsignarEtiquetas();
        }

        private void btnConvertir_Click(object sender, EventArgs e) {
            int opcion = cboTipo.SelectedIndex,
                de = cboDe.SelectedIndex,
                a = cboA.SelectedIndex;
            double cantidad = Double.Parse(txtCantidad.Text);

            lblRespuesta.Text = "Respuesta: " + objConversor.convertirValores(opcion, de, a, cantidad);
        }

        private void cboTipo_Click(object sender, EventArgs e) {
            AsignarEtiquetas();
        }
        private void AsignarEtiquetas() {
            cboDe.Items.Clear();
            cboA.Items.Clear();
            cboDe.Items.AddRange(objConversor.etiquetas[cboTipo.SelectedIndex]);
            cboA.Items.AddRange(objConversor.etiquetas[cboTipo.SelectedIndex]);
        }
    }
    class convertir {
        public String[][] etiquetas = new string[][] {
            new string[]{"Libras","Kilogramos"},
            new string[]{"Metros","Yarda", "Centimetro", "Milimetro"}
            
        };
        Double[][] valores = new Double[][] {
            new double[]{1, 2.20462},
            new double[]{1, 1.09361, 100, 1000}
            
        };
        public Double convertirValores(int opcion, int de, int a, double cantidad) {
            return valores[opcion][de] / valores[opcion][a] * cantidad;
        }
    }
}
