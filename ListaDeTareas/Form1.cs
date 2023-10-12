using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeTareas
{
    public partial class Form1 : Form
    {
        private List<string> tareas = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            string tarea = textBoxTarea.Text;
            if (!string.IsNullOrWhiteSpace(tarea))
            {
                tareas.Add(tarea);
                listBoxTareas.Items.Add(tarea);
                textBoxTarea.Text = "";
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxTareas.SelectedIndex != -1)
            {
                tareas.RemoveAt(listBoxTareas.SelectedIndex);
                listBoxTareas.Items.RemoveAt(listBoxTareas.SelectedIndex);
            }
        }
    }
}
