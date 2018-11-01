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
    public partial class MenuDePartida : Form
    {
        private MDItest opener;

        public Partida unaPartida = new Partida();

        public MDItest _opener
        {
            get { return opener; }
            set { opener = value; }
        }

        public MenuDePartida()
        {
            InitializeComponent();
        }


        private void MenuDePartida_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            lbPregunta.Text = Sesion.getInstance()._categorias[1]._preguntas[3]._descripcion;
            _opener.ocultarBotonesMenu();
            unaPartida.agregarFechaActual();
            Sesion.getInstance().altaPartida(unaPartida);
        }

        private void MenuDePartida_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogRes = MessageBox.Show("¿Desea salir de la partida y volver al menu principal?", "Saliendo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogRes == DialogResult.Yes)
                _opener.mostrarBotonesMenuSesion();
            else
                e.Cancel = true;

        }

        private void btnSalirDePartida_Click(object sender, EventArgs e)
        {
                this.Close();

        }
    }
}
