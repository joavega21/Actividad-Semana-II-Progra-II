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
    public partial class ejercicio9 : Form {
        public ejercicio9() {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e) {
            double n1 = double.Parse(txtValor1.Text);
            double n2 = double.Parse(txtValor2.Text);
            double n3 = double.Parse(txtValor3.Text);
            double n4 = double.Parse(txtValor4.Text);
            double n5 = double.Parse(txtValor5.Text);
            double n6 = double.Parse(txtValor6.Text);
            double n7 = double.Parse(txtValor7.Text);
            double n8 = double.Parse(txtValor8.Text);
            double n9 = double.Parse(txtValor9.Text);
            double n10 = double.Parse(txtValor10.Text);
            if (n1 > n2 & n1 > n3 & n1 > n4 & n1 > n5 & n1 > n6 & n1 > n7 & n1 > n8 & n1 > n9 & n1 > n10) {
                lblRespuesta.Text = "El numero mayor es: " + n1;
            } else if (n2 > n1 & n2 > n3 & n2 > n4 & n2 > n5 & n2 > n6 & n2 > n7 & n2 > n8 & n2 > n9 & n2 > n10) {
                lblRespuesta.Text = "El numero mayor es: " + n2;
            } else if (n3 > n1 & n3 > n2 & n3 > n4 & n3 > n5 & n3 > n6 & n3 > n7 & n3 > n8 & n3 > n9 & n3 > n10) {
                lblRespuesta.Text = "El numero mayor es: " + n3;
            } else if (n4 > n1 & n4 > n2 & n4 > n3 & n4 > n5 & n4 > n6 & n4 > n7 & n4 > n8 & n4 > n9 & n4 > n10) {
                lblRespuesta.Text = "El numero mayor es: " + n4;
            } else if (n5 > n1 & n5 > n2 & n5 > n3 & n5 > n4 & n5 > n6 & n5 > n7 & n5 > n8 & n5 > n9 & n5 > n10) {
                lblRespuesta.Text = "El numero mayor es: " + n5;
            } else if (n6 > n1 & n6 > n2 & n6 > n3 & n6 > n4 & n6 > n5 & n6 > n7 & n6 > n8 & n6 > n9 & n6 > n10) {
                lblRespuesta.Text = "El numero mayor es: " + n6;
            } else if (n7 > n1 & n7 > n2 & n7 > n3 & n7 > n4 & n7 > n5 & n7 > n6 & n7 > n8 & n7 > n9 & n7 > n10) {
                lblRespuesta.Text = "El numero mayor es: " + n7;
            } else if (n8 > n1 & n8 > n2 & n8 > n3 & n8 > n4 & n8 > n5 & n8 > n6 & n8 > n7 & n8 > n9 & n8 > n10) {
                lblRespuesta.Text = "El numero mayor es: " + n8;
            } else if (n9 > n1 & n9 > n2 & n9 > n3 & n9 > n4 & n9 > n5 & n9 > n6 & n9 > n7 & n9 > n8 & n9 > n10) {
                lblRespuesta.Text = "El numero mayor es: " + n9;
            } else if (n10 > n1 & n10 > n2 & n10 > n3 & n10 > n4 & n10 > n5 & n10 > n6 & n10 > n7 & n10 > n8 & n10 > n9) {
                lblRespuesta.Text = "El numero mayor es: " + n10;
            }
        }
    }
}
