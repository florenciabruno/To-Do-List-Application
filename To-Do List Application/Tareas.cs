using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List_Application
{
    class Tareas : IComparable
    {
        private string nombre;
        private string descripcion;
        private DateTime fechaCreacion, fechaEvento;
        public bool terminado = false;

        public string Nombre { get { return nombre; } }
        public string Descripcion { get { return descripcion; } }
        public DateTime FechaCreacion { get { return fechaCreacion; } }
        public DateTime FechaEvento { get { return fechaEvento; } set { fechaEvento = value; } }
        public bool Terminado { get { return terminado; } set { terminado = value; } }

        public Tareas (string n, string d)
        {
            nombre = n;
            descripcion = d;
            fechaCreacion = DateTime.Now;
            fechaEvento = DateTime.Now;
        }

       

        public int CompareTo(Object ob)
        {

            if (ob != null)
            {
                return (fechaEvento.CompareTo(((Tareas)ob).fechaEvento));
            }
            else
                return -1;
        }

        public override string ToString()
        {
            return $"{nombre}: {descripcion} --{FechaEvento.ToString("dd MMMM")}--";
        }
    }



}
    