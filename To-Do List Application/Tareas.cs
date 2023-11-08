using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List_Application
{
    class Tareas
    {
        private string nombre;
        private string descripcion;
        private DateTime fechaCreacion, fechaEvento;
        public bool terminado = false;

        public string Nombre { get { return nombre; } }
        public string Descripcion { get { return descripcion; } }
        public DateTime FechaCreacion { get { return fechaCreacion; } }
        public DateTime FechaEvento { get { return fechaEvento; } set { fechaEvento = value; } }

        public Tareas (string n, string d)
        {
            nombre = n;
            descripcion = d;
            fechaCreacion = DateTime.Now;
        }

    }


}
}
    