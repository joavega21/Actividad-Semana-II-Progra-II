﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISNP151323_Unidad2 {
    public partial class ejercicio1 : Form {
        public ejercicio1() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void btnCalcular_Click(object sender, EventArgs e) {
            double valor = double.Parse(txtValor.Text);
            double respuesta = 0;
            if (chkKilogramos.Checked) {
                respuesta = valor * 0.453592;
                lblResultado.Text = "El resultado es: " + respuesta;
            }else if (chkLibras.Checked) {
                respuesta = valor * 2.20462;
                lblResultado.Text = "El resultado es: " + respuesta;
            }
        }

        private void ejercicio1_Load(object sender, EventArgs e) {

        }
    }
}
