using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class Preguntados
    {
        private Usuario usuario;
        private List<Usuario> listaUsuarios;
       


        public List<Usuario> ListaUsuarios
        {
            get { return listaUsuarios; }
            set { listaUsuarios = value; }
        }

        
        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }



    }
}
