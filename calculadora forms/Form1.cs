using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBoxResultado.Text += button.Text;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text = "";
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
                textBoxResultado.Text = dt.Compute(textBoxResultado.Text, null).ToString();
            }
            catch (Exception ex)
            {
                textBoxResultado.Text = "Error";
            }
        }

    }
}
