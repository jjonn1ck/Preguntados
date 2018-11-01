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
            if (mePudeLoguear)
                this._usuario = unUsuario;
            return mePudeLoguear;
        }

        public void logOUT ()
        {
            if (usuario!=null)
            {
                SesionDAL objDAT = new SesionDAL();
                DateTime thistime = DateTime.Now;
                CultureInfo ci = CultureInfo.InvariantCulture;
                string finSesion;
                finSesion = thistime.ToString("yyyyMMdd HH:mm:ss.FFF", ci);
                objDAT.logOUT(this._usuario._nomUsuario,this._inicioSesion,finSesion);
                usuario = null;
            }
        }

        public bool buscarUsuario(Usuario unUsuario)
        {
            SesionDAL objDAT = new SesionDAL();

            bool encontroUsuario= false;

            encontroUsuario = objDAT.buscarUsuario(unUsuario._nomUsuario).Rows.Count > 0;

            return encontroUsuario;
        }


        public bool altaUsuario(Usuario unUsuario)
        {
            SesionDAL objUsuarioDAL = new SesionDAL();
            int filasAfectadas = objUsuarioDAL.altaUsuario(unUsuario._nomUsuario, unUsuario._Clave);
            if (filasAfectadas == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool buscarPregunta (Pregunta unaPregunta)
        {
            SesionDAL objDAL = new SesionDAL();
            bool encontroPregunta = false;

            encontroPregunta = objDAL.buscarPregunta(unaPregunta._descripcion).Rows.Count > 0;

            return encontroPregunta;

        }

        public bool altaPreguntayRespuestas (Pregunta unaPregunta,string descCategoria)
        {
            SesionDAL objDAL = new SesionDAL();
            int filasAfectadas = objDAL.altaPreguntayRespuestas(unaPregunta._descripcion, descCategoria,Sesion.getInstance()._usuario._nomUsuario,Sesion.getInstance()._inicioSesion);
            if (filasAfectadas == -1)
            {
                return false;
            }
            else
            {
                foreach (Respuesta resps in unaPregunta._respuestas)
                {
                    this.altaRespuesta(resps, unaPregunta._descripcion);
                }
                return true;
            }
        }

        public bool altaRespuesta (Respuesta unaRespuesta,string pregDescripcion)
        {
            SesionDAL objDAL = new SesionDAL();
            int filasAfectadas = objDAL.altaRespuesta(unaRespuesta._descripcion, unaRespuesta._correcto, pregDescripcion);
            if (filasAfectadas == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void altaPartida (Partida unaPartida)
        {
            SesionDAL objDAL = new SesionDAL();
            objDAL.altaPartida(unaPartida._fechaInicio, this._inicioSesion, this._usuario._nomUsuario);
        }
    }
}
