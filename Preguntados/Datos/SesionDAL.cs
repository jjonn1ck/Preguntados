using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{ 
    public class SesionDAL
    {
        public int Alta(string nomUsuario)
        {
            Conexion objConexion = new Conexion();
            // string consultaDeInsert = "insert into Sesion values ('"+nomUsuario + "'," + fechaInicio + ")";
            string nombreSP = "sesion_alta";
            SqlParameter[] parametrosParaElStoreProcedure = new SqlParameter[1];
            parametrosParaElStoreProcedure[0] = objConexion.crearParametro("@nombre", nomUsuario);
            int filasafectadas = objConexion.EscribirPorStoreProcedure(nombreSP, parametrosParaElStoreProcedure);
            return filasafectadas;
        }
    }
}
