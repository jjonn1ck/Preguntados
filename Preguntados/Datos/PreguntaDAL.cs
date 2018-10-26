using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Datos
{
    public class PreguntaDAL
    {
        public DataTable listarPorCategoria(int id_categoria)
        {
            Conexion objConexion = new Conexion();
            return objConexion.LeerPorComando("select * from Pregunta where idCategoria=" + id_categoria);
        }

        public void guardarPregunta(string pregunta,int idCategoria)
        {
            Conexion objConexion = new Conexion();
            objConexion.EscribirPorComando("insert into Pregunta values ('"+pregunta+"',"+idCategoria+")");
        }






    }
}
