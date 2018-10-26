using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;


namespace Logica
{
    public class Usuario
    {



        private string Clave;

        public string _Clave
        {
            get { return Clave; }
            set { Clave = value; }
        }



        private string nomUsuario;

        public string _nomUsuario
        {
            get { return  nomUsuario; }
            set {  nomUsuario = value; }
        }


        public bool logIN(string nombreUsuario, string ClaveUsuario)
        {
            UsuarioDAT objDAT = new UsuarioDAT();

            bool mePudeLoguear = false;

            mePudeLoguear = objDAT.logIN(nombreUsuario,ClaveUsuario).Rows.Count > 0;

            return mePudeLoguear;



            

                   
        }



        /*
        public bool LogIN()
        {
            UsuarioDAT objDAT = new UsuarioDAT();

            
            DataTable tabla  = objDAT.logIN(this.nomUsuario, this.Clave);

            if tabla.Rows
            


            return true;

            
        }
        */

    }
}
