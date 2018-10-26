using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class Usuario
    {
        private string nick;
        private string clave;


        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }


        public string Nick
        {
            get { return nick; }
            set { nick = value; }
        }


    }
}
