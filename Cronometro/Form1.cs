using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cronometro
{
    public partial class Form1 : Form
    {
        private int segundos = 0;

        public Form1()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(timer_Tick);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            segundos++;
            labelTiempo.Text = $"{segundos}";
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void buttonDetener_Click(object sender, EventArgs e)
        {
            if (timer.Enabled == false)
            {
                segundos = 0;
                labelTiempo.Text = "0";
            }
            else {
                timer.Stop();
            }

        }

    }
}
