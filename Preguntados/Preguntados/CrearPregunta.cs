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
    public partial class CrearPregunta : Form
    {
        public CrearPregunta()
        {
            InitializeComponent();
        }

        private MDItest opener;

        public MDItest _opener
        {
            get { return opener; }
            set { opener = value; }
        }

        private void CrearPregunta_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Categoria categoria = new Categoria();
            cmbCategoria.DataSource = categoria.Listar();
            cmbCategoria.DisplayMember = "_descripcion";
            cmbCategoria.ValueMember = "_id";


        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Pregunta pregunta = new Pregunta();
            string categoria;
            pregunta._descripcion = txtPregunta.Text;
            categoria = cmbCategoria.Text;
            Respuesta respuesta1 = new Respuesta();
            respuesta1._descripcion = txtOpcion1.Text;
            Respuesta respuesta2 = new Respuesta();
            respuesta2._descripcion = txtOpcion2.Text;
            Respuesta respuesta3 = new Respuesta();
            respuesta3._descripcion = txtOpcion3.Text;
            Respuesta respuesta4 = new Respuesta();
            respuesta4._descripcion = txtOpcion4.Text;






=======
            Pregunta unaPregunta = new Pregunta();
            Respuesta unaRespuesta = new Respuesta();
            Respuesta unaRespuesta2 = new Respuesta();
            Respuesta unaRespuesta3 = new Respuesta();
            Respuesta unaRespuesta4 = new Respuesta();
            unaPregunta._descripcion = txtPregunta.Text;
            unaRespuesta._descripcion = txtOpcion1.Text;
            unaRespuesta._correcto = rdOpcion1.Checked;
            unaPregunta._respuestas.Add(unaRespuesta);
            unaRespuesta2._descripcion = txtOpcion2.Text;
            unaRespuesta2._correcto = rdOpcion2.Checked;
            unaPregunta._respuestas.Add(unaRespuesta2);
            unaRespuesta3._descripcion = txtOpcion3.Text;
            unaRespuesta3._correcto = rdOpcion3.Checked;
            unaPregunta._respuestas.Add(unaRespuesta3);
            unaRespuesta4._descripcion = txtOpcion4.Text;
            unaRespuesta4._correcto = rdOpcion4.Checked;
            unaPregunta._respuestas.Add(unaRespuesta4);
            if (!Sesion.getInstance().buscarPregunta(unaPregunta))
            { 
                Sesion.getInstance().altaPreguntayRespuestas(unaPregunta, cmbCategoria.Text);
                MessageBox.Show("La pregunta se ha creado satisfactoriamente","Creacion de pregunta",MessageBoxButtons.OK);
                this.Close();
            }
             else
                MessageBox.Show("No se pudo crear la pregunta porque ya existe", "Creacion de pregunta", MessageBoxButtons.OK);
>>>>>>> RamaDeBRIAN

        }

        private void CrearPregunta_FormClosed(object sender, FormClosedEventArgs e)
        {
            opener.mostrarBotonesMenuSesion();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
