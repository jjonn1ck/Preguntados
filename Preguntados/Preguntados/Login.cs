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
        private MDItest opener;

        public MDItest _opener
        {
            get { return opener; }
            set { opener = value; }
        }


        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {


            Sesion objSesion = Sesion.getInstance();
            Usuario objUsuario = new Usuario();

            objUsuario._nomUsuario = txtUsuario.Text;
            objUsuario._Clave = txtContraseña.Text;



            if (objSesion.logIN(objUsuario) == true)
            {
                MessageBox.Show("Te logueaste de forma correcta");
                Sesion.getInstance().Alta();
                opener.toolStripStatusLabel.Text = "Sesion iniciada con el usuario '" + Sesion.getInstance()._usuario._nomUsuario + "'";
               
                this.Close();

            }
            else
            {
                MessageBox.Show("NO Te logueaste de forma correcta");
                opener.toolStripStatusLabel.Text = "Sesion no iniciado";
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            opener.jUGARToolStripMenuItem.Visible = false;
            opener.iniciarSesionToolStripMenuItem.Visible = false;
            opener.vERTOPSToolStripMenuItem.Visible = false;
            opener.crearPreguntaToolStripMenuItem.Visible = false;
            opener.cerrarSesionToolStripMenuItem.Visible = false;
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            CrearUsuario formcrear = new CrearUsuario();
            formcrear.ShowDialog();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {

            //MDItest frm = Owner as MDItest;
            if (Sesion.getInstance()._usuario == null)
            {
                opener.jUGARToolStripMenuItem.Visible = false;
                opener.iniciarSesionToolStripMenuItem.Visible = true;
                opener.vERTOPSToolStripMenuItem.Visible = false;
                opener.crearPreguntaToolStripMenuItem.Visible = false;
                opener.cerrarSesionToolStripMenuItem.Visible = false;
              }
            else
            {
                opener.iniciarSesionToolStripMenuItem.Visible = false;
                opener.jUGARToolStripMenuItem.Visible = true;
                opener.vERTOPSToolStripMenuItem.Visible = true;
                opener.crearPreguntaToolStripMenuItem.Visible = true;
                opener.cerrarSesionToolStripMenuItem.Visible = true;
            }

        }
    }
}
