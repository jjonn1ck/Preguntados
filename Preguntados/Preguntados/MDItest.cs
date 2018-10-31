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
    public partial class MDItest : Form
    {
        private int childFormNumber = 0;

        public MDItest()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

    

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login unFormulario = new Login();
             unFormulario.MdiParent = this;
            unFormulario._opener = this;
            unFormulario.Show();

            
        }

        private void MDItest_Load(object sender, EventArgs e)
        {
            this.Text = "Preguntados";
            mostrarBotonesMenuInicioSesion();
        }


        private void MDItest_Enter(object sender, EventArgs e)
        {
        }

        private void MDItest_EnabledChanged(object sender, EventArgs e)
        {
       
        }

        private void MDItest_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("¿Desea cerrar sesion?", "Saliendo",MessageBoxButtons.YesNo);
            if (result==DialogResult.Yes)
            {
                Sesion.getInstance().logOUT();
                toolStripStatusLabel.Text = "Sesion no iniciada";
                mostrarBotonesMenuInicioSesion();
            }
                
        }

        private void crearPreguntaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearPregunta unFormulario = new CrearPregunta();
            unFormulario.MdiParent = this;
            unFormulario._opener = this;
            unFormulario.Show();
        }

        public void mostrarBotonesMenuInicioSesion()
        {
            jUGARToolStripMenuItem.Visible = false;
            iniciarSesionToolStripMenuItem.Visible = true;
            vERTOPSToolStripMenuItem.Visible = false;
            crearPreguntaToolStripMenuItem.Visible = false;
            cerrarSesionToolStripMenuItem.Visible = false;
        }
        
        public void ocultarBotonesMenu()
        {
            jUGARToolStripMenuItem.Visible = false;
            iniciarSesionToolStripMenuItem.Visible = false;
            vERTOPSToolStripMenuItem.Visible = false;
            crearPreguntaToolStripMenuItem.Visible = false;
            cerrarSesionToolStripMenuItem.Visible = false;
        }

        public void mostrarBotonesMenuSesion()
        {
            iniciarSesionToolStripMenuItem.Visible = false;
            jUGARToolStripMenuItem.Visible = true;
            vERTOPSToolStripMenuItem.Visible = true;
            crearPreguntaToolStripMenuItem.Visible = true;
            cerrarSesionToolStripMenuItem.Visible = true;
        }

        private void jUGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuDePartida objMenuPartida = new MenuDePartida();
            objMenuPartida._opener = this;
            objMenuPartida.MdiParent = this;
            objMenuPartida.Show();
            this.ocultarBotonesMenu();



        }
    }
}
