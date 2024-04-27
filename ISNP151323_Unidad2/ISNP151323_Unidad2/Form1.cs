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
    }
}
