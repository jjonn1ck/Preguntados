using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Datos
{
    public class UsuarioDAT
    {
        public DataTable logIN(string pNomUsuario, string pClave)
         {
             Conexion objConexion = new Conexion();

             string nombreSPLog = "buscar_usuario";

             SqlParameter[] parametroStoreLog = new SqlParameter[2];

             parametroStoreLog[0] = objConexion.crearParametro("@par1", pNomUsuario);
             parametroStoreLog[1] = objConexion.crearParametro("@par2", pClave);

             DataTable filasAfectadas = objConexion.LeerPorStoreProcedure(nombreSPLog, parametroStoreLog);

             return filasAfectadas;


         }
         
        /*
        public DataTable logIN()
        {
            Conexion objConexion = new Conexion();
            string consultaSQL = "buscar_usuario";
            DataTable objLog = objConexion.LeerPorStoreProcedure(consultaSQL, null);
            return objLog;
            

        }
        */


    }
}
