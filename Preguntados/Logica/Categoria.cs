using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Logica
{
    public class Categoria
    {
      
        private int id;

        public int _id
        {
            get { return id; }
            set { id = value; }
        }

        private string descripcion;

        public string _descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private List<Pregunta> preguntas;

        public List<Pregunta> _preguntas
        {
            get { return preguntas; }
            set { preguntas = value; }
        }


        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();
            CategoriaDAL dal = new CategoriaDAL();
            Categoria unaCategoria;

            foreach(DataRow fila in dal.listar().Rows)
            {
                unaCategoria = new Categoria();
                unaCategoria._descripcion = fila["nombre"].ToString();
                unaCategoria._id = int.Parse(fila["idCategoria"].ToString());
                lista.Add(unaCategoria);

            }
            return lista;
           
        }

        public List<Categoria> cargarCategoriasPreguntasRespuestas()
        {
            List<Categoria> lista = new List<Categoria>();
            CategoriaDAL dal = new CategoriaDAL();
        Categoria unaCategoria;

            foreach(DataRow fila in dal.listar().Rows)
            {
                unaCategoria = new Categoria();
                unaCategoria._descripcion = fila["nombre"].ToString();
                unaCategoria._id = int.Parse(fila["idCategoria"].ToString());
                unaCategoria.cargarPreguntas();
                lista.Add(unaCategoria);

            }
            return lista;

        }

        public void cargarPreguntas()
        {
            Pregunta objpregunta = new Pregunta();
            _preguntas = objpregunta.listarPorCategoria(_id);
            
            }
            
        }

    




    }

