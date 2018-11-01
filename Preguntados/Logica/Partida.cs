using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Globalization;

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

        private string fechaInicio;

        public string _fechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
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

        public void agregarFechaActual()
        {
            DateTime thistime = DateTime.Now;
            CultureInfo ci = CultureInfo.InvariantCulture;
            this.fechaInicio = thistime.ToString("yyyyMMdd HH:mm:ss.FFF", ci);

        }


    }
}
