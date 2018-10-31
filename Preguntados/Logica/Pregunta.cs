using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Logica
{
    public class Pregunta
    {
        private int id;

        public int _id
        {
            get { return id; }
            set { id = value; }
        }

        private string descripcion;

        public string _descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private Boolean contestado;

        public Boolean _contestado
        {
            get { return contestado; }
            set { contestado = value; }
        }

        private List<Respuesta> respuestas=new List<Respuesta>();

        public List<Respuesta> _respuestas
        {
            get { return respuestas; }
            set { respuestas = value; }
        }

        public Pregunta()
        {
            contestado = false;
        }

        public List<Pregunta> listarPorCategoria(int id_categoria)
        {
            List<Pregunta> lista = new List<Pregunta>();
            PreguntaDAL dal = new PreguntaDAL();
            Pregunta unaPregunta;

            foreach (DataRow fila in dal.listarPorCategoria(id_categoria).Rows)
            {
                unaPregunta = new Pregunta();
                unaPregunta._descripcion = fila["descripcion"].ToString();
                unaPregunta._id = int.Parse(fila["idPregunta"].ToString());
                unaPregunta.cargarRespuestas();
                lista.Add(unaPregunta);

            }

            return lista;

        }

        public void cargarRespuestas()
        {
            Respuesta objRespuesta = new Respuesta();
            _respuestas = objRespuesta.listarPorPregunta(_id);
        }


        public void alta()
        {

        }
    }
}
