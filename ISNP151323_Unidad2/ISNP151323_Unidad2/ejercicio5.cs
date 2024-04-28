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
    public partial class ejercicio5 : Form {
        public ejercicio5() {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void btnCalcular_Click(object sender, EventArgs e) {
            double lab1 = double.Parse(txtLab1.Text),
                   lab2 = double.Parse(txtLab2.Text),
                   lab3 = double.Parse(txtLab3.Text),
                   par1 = double.Parse(txtPar1.Text),
                   par2 = double.Parse(txtPar2.Text),
                   par3 = double.Parse(txtPar3.Text);
            double promedio = 0;//, suma = 0;
            promedio = (lab1 + lab2 + lab3 + par1 + par2 + par3)/6;
            if(promedio >= 6){
                lblPromedio.Text = "El promedio del alumno es: " + Math.Round(promedio, 1);
                lblEstado.Text = "Aprobado";
            } else {
                lblPromedio.Text = "El promedio del alumno es: " + Math.Round(promedio, 1);
                lblEstado.Text = "Reprobado";
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e) {
            txtLab1.Clear();
            txtLab2.Clear();
            txtLab3.Clear();
            txtPar1.Clear();
            txtPar2.Clear();
            txtPar3.Clear();
        }

        private void ejercicio5_Load(object sender, EventArgs e) {

        }
    }
}
