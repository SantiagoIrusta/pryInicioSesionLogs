using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryInicioSesionLogs
{
    public partial class frmAdministrador : Form
    {
        clsUsuario usuario;
        public frmAdministrador()
        {
            InitializeComponent();
            usuario = new clsUsuario();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text != "" && txtContraseña.Text != "" && txtPerfil.Text != "")
            {
                
            }
        }
    }
}
