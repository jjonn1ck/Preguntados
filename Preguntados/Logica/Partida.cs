using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public class Partida
    {
        private int id;

        public int _id
        {
            get { return id; }
            set { id = value; }
        }

        private Sesion sesion;

        public Sesion _sesion
        {
            get { return sesion; }
            set { sesion = value; }
        }

        private int puntaje;

        public int _puntaje
        {
            get { return puntaje; }
            set { puntaje = value; }
        }

        private Pregunta pregunta;

        public Pregunta _pregunta
        {
            get { return pregunta; }
            set { pregunta = value; }
        }



    }
}
