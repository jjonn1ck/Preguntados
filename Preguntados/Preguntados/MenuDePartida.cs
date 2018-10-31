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

        }
    }
}
