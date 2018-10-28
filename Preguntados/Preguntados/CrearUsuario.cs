using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Preguntados
{
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
        }


        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            if (txtPassword1.Text == txtPassword2.Text)
            {
                Usuario unUsuario = new Usuario();
                unUsuario._nomUsuario = txtUsuario.Text;
                unUsuario._Clave = txtPassword1.Text;
                if (unUsuario.buscarUsuario(unUsuario._nomUsuario)== false)
                {
                    if (unUsuario.alta())
                    {
                        MessageBox.Show("El usuario ha sido creado correctamente");
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo crear el usuario porque ya existe");
                }

            }
            else
            {
                MessageBox.Show("Ambas contraseñas ingresadas no coinciden o se olvido escribir una");
            }

        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
