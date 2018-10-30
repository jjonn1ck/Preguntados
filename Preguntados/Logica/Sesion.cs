using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public class Sesion
    {

        private static Sesion instance = null;
        private int id;

        public int _id
        {
            get { return id; }
            set { id = value; }
        }

        private string inicioSesion;

        public string _inicioSesion
        {
            get { return inicioSesion; }
            set { inicioSesion = value; }
        }

        private Usuario usuario;

        public Usuario _usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        private List<Categoria> categorias = new List<Categoria>();

        public List<Categoria> _categorias
        {
            get { return categorias; }
            set { categorias = value; }
        }

        private Sesion()
        {
            cargarCategorias();
        }
      
        public static Sesion getInstance()
        {
            if (instance == null)
                instance = new Sesion();
            return instance;
        }

        public void Alta()
        {
            DateTime thistime = DateTime.Now;
            CultureInfo ci = CultureInfo.InvariantCulture;
            SesionDAL objDAL = new SesionDAL();
            this._inicioSesion = thistime.ToString("yyyyMMdd HH:mm:ss.FFF", ci);
            objDAL.Alta(this._usuario._nomUsuario,this._inicioSesion);
        }

        public void cargarCategorias()
        {
            Categoria objCategoria = new Categoria();
            _categorias = objCategoria.cargarCategoriasPreguntasRespuestas();
        }

        public bool logIN(Usuario unUsuario)
        {
            SesionDAL objDAT = new SesionDAL();

            bool mePudeLoguear = false;

            mePudeLoguear = objDAT.logIN(unUsuario._nomUsuario, unUsuario._Clave).Rows.Count > 0;

            return mePudeLoguear;
        }

        public bool buscarUsuario(Usuario unUsuario)
        {
            SesionDAL objDAT = new SesionDAL();

            bool mePudeLoguear = false;

            mePudeLoguear = objDAT.buscarUsuario(unUsuario._nomUsuario).Rows.Count > 0;

            return mePudeLoguear;
        }


        public bool altaUsuario(Usuario unUsuario)
        {
            SesionDAL objUsuarioDAT = new SesionDAL();
            int filasAfectadas = objUsuarioDAT.altaUsuario(unUsuario._nomUsuario, unUsuario._Clave);
            if (filasAfectadas == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
