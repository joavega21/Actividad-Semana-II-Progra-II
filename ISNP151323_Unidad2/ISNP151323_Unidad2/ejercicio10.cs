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
    public partial class ejercicio10 : Form {
        public ejercicio10() {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e) {
            string usuario = txtUsuario.Text,
                   contraseña = txtContraseña.Text;
            if(usuario == "ugb" && contraseña == "ugb") {
                MessageBox.Show("Bienvenido!!");
            } else {
                MessageBox.Show("Acceso denegado");
            }
        }

        private void ejercicio10_Load(object sender, EventArgs e) {

        }
    }
}
