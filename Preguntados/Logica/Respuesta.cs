using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Logica
{
    public class Respuesta
    {
        private string descripcion;
        private int id;

        public int _id
        {
            get { return id; }
            set { id = value; }
        }

        public string _descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private Boolean correcto;

        public Boolean _correcto
        {
            get { return correcto; }
            set { correcto = value; }
        }

        public List<Respuesta> listarPorPregunta (int id_pregunta)
        {
            List<Respuesta> lista = new List<Respuesta>();
            RespuestaDAL dal = new RespuestaDAL();
            Respuesta unaRespuesta;

            foreach (DataRow fila in dal.listarPorPregunta(id_pregunta).Rows)
            {
                unaRespuesta = new Respuesta();
                unaRespuesta._descripcion= fila["descripcion"].ToString();
                unaRespuesta._id = int.Parse(fila["idRespuesta"].ToString());
                unaRespuesta._correcto = bool.Parse(fila["correcto"].ToString());
                lista.Add(unaRespuesta);

            }

            return lista;
        }


    }
}
