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
    public partial class principal : Form {
        public principal() {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e) {
            ejercicio1 objEejercicio1 = new ejercicio1();
            objEejercicio1.Show();
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e) {
            ejercicio2 objEejercicio2 = new ejercicio2();
            objEejercicio2.Show();
        }

        private void ejercicio5ToolStripMenuItem_Click(object sender, EventArgs e) {
            ejercicio3 objEejercicio3 = new ejercicio3();
            objEejercicio3.Show();
        }

        private void ejercicio7ToolStripMenuItem_Click(object sender, EventArgs e) {
            ejercicio4 objEejercicio4 = new ejercicio4();
            objEejercicio4.Show();
        }

        private void ejercicio9ToolStripMenuItem_Click(object sender, EventArgs e) {
            ejercicio5 objEejercicio5 = new ejercicio5();
            objEejercicio5.Show();
        }

        private void ejercicio6ToolStripMenuItem1_Click(object sender, EventArgs e) {
            ejercicio6 objEejercicio6 = new ejercicio6();
            objEejercicio6.Show();
        }

        private void ejercicio7ToolStripMenuItem1_Click(object sender, EventArgs e) {
            ejercicio7 objEejercicio7 = new ejercicio7();
            objEejercicio7.Show();
        }

        private void ejercicio8ToolStripMenuItem1_Click(object sender, EventArgs e) {
            ejercicio8 objEejercicio8 = new ejercicio8();
            objEejercicio8.Show();
        }

        private void ejercicio9ToolStripMenuItem1_Click(object sender, EventArgs e) {
            ejercicio9 objEejercicio9 = new ejercicio9();
            objEejercicio9.Show();
        }

        private void ejercicio10ToolStripMenuItem2_Click(object sender, EventArgs e) {
            ejercicio10 objEejercicio10 = new ejercicio10();
            objEejercicio10.Show();
        }

        private void principal_Load(object sender, EventArgs e) {

        }
    }
}
