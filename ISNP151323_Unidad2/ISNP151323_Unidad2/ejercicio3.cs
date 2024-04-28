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
    public partial class ejercicio3 : Form {

        double num1 = 0, num2 = 0;
        char operador;
        public ejercicio3() {
            InitializeComponent();
        }

        private void ejercicio3_Load(object sender, EventArgs e) {

        }
        private void AgregarNumero(object sender, EventArgs e) {
            var boton = ((Button)sender);
            if (txtResultado.Text == "0") {
                txtResultado.Text = "";
            }
            txtResultado.Text += boton.Text;
        }

        private void btnIgual_Click(object sender, EventArgs e) {
            num2 = Convert.ToDouble(txtResultado.Text);
            if (operador == '+') {
                txtResultado.Text = (num1 + num2).ToString();
                num1 = Convert.ToDouble(txtResultado.Text);
            }else if (operador == '-') {
                txtResultado.Text = (num1 - num2).ToString();
                num1 = Convert.ToDouble(txtResultado.Text);
            }else if (operador == 'x') {
                txtResultado.Text = (num1 * num2).ToString();
                num1 = Convert.ToDouble(txtResultado.Text);
            }else if (operador == '/') {
                if(txtResultado.Text != "0") { 
                txtResultado.Text = (num1 / num2).ToString();
                num1 = Convert.ToDouble(txtResultado.Text);
                } else {
                    MessageBox.Show("No se puede dividir entre 0");
                }
            } else if (operador == '^') {
                txtResultado.Text = (Math.Pow(num1, num2)).ToString();
                num1 = Convert.ToDouble(txtResultado.Text);
            }
        }

        private void btnC_Click(object sender, EventArgs e) {
            num1 = 0;
            num2 = 0;
            operador = '\0';
            txtResultado.Text = "0";
        }

        private void btnCe_Click(object sender, EventArgs e) {
            txtResultado.Text = "0";
        }

        private void btnPunto_Click(object sender, EventArgs e) {
            if (!txtResultado.Text.Contains(".")){
                txtResultado.Text += ".";

            }
        }

        private void clickOperador(object sender, EventArgs e) {
            var boton = ((Button)sender);
            num1 = Convert.ToDouble(txtResultado.Text);
            operador = Convert.ToChar(boton.Tag);
            if (operador == '√') {
                num1 = Math.Sqrt(num1);
                txtResultado.Text = num1.ToString();
            }else { 
                txtResultado.Text = "0";
            }
        }
    }
}
