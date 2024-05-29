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
    public partial class Form1 : Form
    {
        clsUsuario usuario;

        public Form1()
        {
            InitializeComponent();
            usuario = new clsUsuario();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            
            if (txtUsuario.Text != "" && txtContraseña.Text != "")
            {
               

                usuario.ValidarUsuario(txtUsuario.Text, txtContraseña.Text);

                MessageBox.Show(usuario.estadoConexion);

                if(usuario.estadoConexion == "Usuario EXISTE")
                {
                    usuario.RegistroLogInicioSesion();

                    MessageBox.Show(usuario.estadoConexion);

                    txtUsuario.Clear();
                    txtContraseña.Clear();
                }

               
            }
            else
            {
                MessageBox.Show("Debe colocal los datos");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
