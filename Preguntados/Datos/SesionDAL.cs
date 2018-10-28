﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

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

        public DataTable buscarUsuario(string pNomUsuario)
        {
            Conexion objConexion = new Conexion();

            string nombreSPLog = "buscar_usuarioXnombre";

            SqlParameter[] parametroStoreLog = new SqlParameter[1];

            parametroStoreLog[0] = objConexion.crearParametro("@par1", pNomUsuario);

            DataTable filasAfectadas = objConexion.LeerPorStoreProcedure(nombreSPLog, parametroStoreLog);

            return filasAfectadas;
        }

        public int altaUsuario(string usuario, string password)
        {
            Conexion objconexion = new Conexion();
            string nombreProcedure = "usuario_alta";
            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = objconexion.crearParametro("nom", usuario);
            parametros[1] = objconexion.crearParametro("pass", password);
            int filasAfectadas = objconexion.EscribirPorStoreProcedure(nombreProcedure, parametros);
            return filasAfectadas;
        }
    }
}
