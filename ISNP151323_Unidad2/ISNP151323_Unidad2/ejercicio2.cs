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
        public ejercicio2() {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e) {
            if (cmbDe.SelectedItem.ToString() == "Metros" && cmbA.SelectedItem.ToString() == "Metros") {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 1;
                lblRespuesta.Text = "Respuesta: " + Math.Round(conversion,4);
            } else if (cmbDe.SelectedItem.ToString() == "Metros" && cmbA.SelectedItem.ToString() == "Yardas") {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 1.09361;
                lblRespuesta.Text = "Respuesta: " + Math.Round(conversion,4);
            } else if (cmbDe.SelectedItem.ToString() == "Metros" && cmbA.SelectedItem.ToString() == "Centimetros") {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 100;
                lblRespuesta.Text = "Respuesta: " + Math.Round(conversion, 4);
            } else if (cmbDe.SelectedItem.ToString() == "Metros" && cmbA.SelectedItem.ToString() == "Milimetros") {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 1000;
                lblRespuesta.Text = "Respuesta: " + Math.Round(conversion, 4);
            } else if (cmbDe.SelectedItem.ToString() == "Yardas" && cmbA.SelectedItem.ToString() == "Yardas") {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 1;
                lblRespuesta.Text = "Respuesta: " + Math.Round(conversion, 4);
            } else if (cmbDe.SelectedItem.ToString() == "Yardas" && cmbA.SelectedItem.ToString() == "Metros") {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 0.9144;
                lblRespuesta.Text = "Respuesta: " + Math.Round(conversion, 4);
            } else if (cmbDe.SelectedItem.ToString() == "Yardas" && cmbA.SelectedItem.ToString() == "Centimetros") {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 91.44;
                lblRespuesta.Text = "Respuesta: " + Math.Round(conversion, 4);
            } else if (cmbDe.SelectedItem.ToString() == "Yardas" && cmbA.SelectedItem.ToString() == "Milimetros") {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 914.4;
                lblRespuesta.Text = "Respuesta: " + Math.Round(conversion, 4);
            } else if (cmbDe.SelectedItem.ToString() == "Centimetros" && cmbA.SelectedItem.ToString() == "Centimetros") {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 1;
                lblRespuesta.Text = "Respuesta: " + Math.Round(conversion, 4);
            } else if (cmbDe.SelectedItem.ToString() == "Centimetros" && cmbA.SelectedItem.ToString() == "Metros") {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 0.01;
                lblRespuesta.Text = "Respuesta: " + Math.Round(conversion, 4);
            } else if (cmbDe.SelectedItem.ToString() == "Centimetros" && cmbA.SelectedItem.ToString() == "Yardas") {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 0.0109361;
                lblRespuesta.Text = "Respuesta: " + Math.Round(conversion, 4);
            } else if (cmbDe.SelectedItem.ToString() == "Centimetros" && cmbA.SelectedItem.ToString() == "Milimetros") {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 10;
                lblRespuesta.Text = "Respuesta: " + Math.Round(conversion, 4);
            } else if (cmbDe.SelectedItem.ToString() == "Milimetros" && cmbA.SelectedItem.ToString() == "Milimetros") {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 1;
                lblRespuesta.Text = "Respuesta: " + Math.Round(conversion, 4);
            } else if (cmbDe.SelectedItem.ToString() == "Milimetros" && cmbA.SelectedItem.ToString() == "Metros") {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 0.001;
                lblRespuesta.Text = "Respuesta: " + Math.Round(conversion, 4);
            } else if (cmbDe.SelectedItem.ToString() == "Milimetros" && cmbA.SelectedItem.ToString() == "Yardas") {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 0.00109361;
                lblRespuesta.Text = "Respuesta: " + Math.Round(conversion, 4);
            } else if (cmbDe.SelectedItem.ToString() == "Milimetros" && cmbA.SelectedItem.ToString() == "Centimetros") {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 0.1;
                lblRespuesta.Text = "Respuesta: " + Math.Round(conversion, 4);
            }
        }
    }
}
