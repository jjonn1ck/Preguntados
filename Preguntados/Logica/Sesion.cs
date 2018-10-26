using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public class Sesion
    {
        private Usuario usuario;
        private int id;
        private List<Categoria> categorias = new List<Categoria>();

        public int _id
        {
            get { return id; }
            set { id = value; }
        }




        public Usuario _usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

       

        public List<Categoria> _categorias
        {
            get { return categorias; }
            set { categorias = value; }
        }

        public Sesion()
        {
            cargarCategorias();
        }
      

        public void Alta()
        {
            SesionDAL objDAL = new SesionDAL();
            objDAL.Alta(this._usuario._nomUsuario);
        }

        public void cargarCategorias()
        {
            Categoria objCategoria = new Categoria();
            _categorias = objCategoria.Listar();
        }

    }
}
