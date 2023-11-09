using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace To_Do_List_Application
{
    class Sistema
    {
        private string[] listaCategorias = new string[50];
        private List<Tareas> listaTareas = new List<Tareas>();

        public List<Tareas> ListaTareas { get { return listaTareas; } }

        public Sistema()
        { }

        public bool AgregarTarea(Tareas t)
        {
            if (!listaTareas.Contains(t))
            {
                listaTareas.Add(t);
                listaTareas.Sort();
                return true;
            }
            else
                return false;           
        }

        public bool EliminarTarea(Tareas t)
        {
            int b = buscarTarea(t);
            if(b>=0)
            {
                listaTareas.RemoveAt(b);
                return true;
            }
            return false;
        }

        private int buscarTarea(Tareas t)
        {
            listaTareas.Sort();
            int buscar = listaTareas.BinarySearch(t);

            return buscar;
        }

        public List<Tareas> VerTareas()
        {
            return listaTareas;
        }
    }
}
