using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Sistema miSistema = new Sistema();
        Tareas nueva;
        fecha ventanaFecha = new fecha();

        private void button1_Click(object sender, EventArgs e) //crear tarea
        {
            if (!string.IsNullOrEmpty(tbNombre.Text))
            {
                nueva = new Tareas(tbNombre.Text, tbDescripcion.Text);
                miSistema.AgregarTarea(nueva);
                Ordenarlista();
                tbNombre.Clear();
                tbDescripcion.Clear();

            }
            else
                MessageBox.Show("Escribe un nombre");
            

        }

        private void button2_Click(object sender, EventArgs e) //Eliminar tarea
        {
            List<Tareas> sel = new List<Tareas>();
            int cantSeeleccionado = checkedListBox1.CheckedIndices.Count;
            if (cantSeeleccionado > 0)
            {

                foreach (int seleccionado in checkedListBox1.CheckedIndices)
                {
                    nueva = miSistema.ListaTareas[seleccionado];
                    sel.Add(nueva);
                }
                foreach (Tareas t in sel)
                {
                    miSistema.EliminarTarea(t);
                }
                sel.Clear();
                Ordenarlista();
            }


        }

        public void Ordenarlista()
        {
            checkedListBox1.Items.Clear();
            miSistema.ListaTareas.Sort();
            foreach (Tareas t in miSistema.VerTareas())
            {
                checkedListBox1.Items.Add(t.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e) // cambiar fecha
        {
            if(checkedListBox1.SelectedIndex>-1)
            {
                DateTime fecha;
                int sel = checkedListBox1.SelectedIndex;
                nueva = miSistema.ListaTareas[sel];

                if (ventanaFecha.ShowDialog() == DialogResult.OK)
                {
                    fecha = ventanaFecha.dateTimePicker1.Value;
                    nueva.FechaEvento = fecha;
                    Ordenarlista();
                }
            }
            else
            {
                MessageBox.Show("seleccioná una tarea");
            }
            





        }
    }
}
