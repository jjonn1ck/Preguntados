using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Datos
{
    public class RespuestaDAL
    {
        public DataTable listarPorPregunta(int id_pregunta)
        {
            Conexion objConexion = new Conexion();
            return objConexion.LeerPorComando("select * from Respuesta where idPregunta=" + id_pregunta);
        }
    }
}
