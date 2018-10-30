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

    public partial class MenuDeSesion : Form
    {

        public MenuDeSesion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
          /*  Text = "Preguntados";
            Sesion sesion = new Sesion();
            Usuario usuario = new Usuario();
            usuario._nomUsuario = "Brian";
            usuario._Clave = "1234";
            sesion._usuario = usuario;
            sesion.Alta();*/
            
            
          




        }

        private void btnCrearPregunta_Click(object sender, EventArgs e)
        {
            CrearPregunta crearPregunta = new CrearPregunta();
            crearPregunta.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
