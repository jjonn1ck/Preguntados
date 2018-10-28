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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {


            Usuario objUsuario = new Usuario();

            objUsuario._nomUsuario = txtUsuario.Text;
            objUsuario._Clave = txtContraseña.Text;




            if (objUsuario.logIN(objUsuario._nomUsuario, objUsuario._Clave) == true

                )
            {
                MessageBox.Show("Te logueaste de forma correcta");

            }
            else
            {
                MessageBox.Show("NO Te logueaste de forma correcta");
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            CrearUsuario formcrear = new CrearUsuario();
            formcrear.ShowDialog();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }
    }
}
