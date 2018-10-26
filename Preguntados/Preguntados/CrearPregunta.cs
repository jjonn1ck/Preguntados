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

        private void CrearPregunta_Load(object sender, EventArgs e)
        {
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




        }
    }
}
