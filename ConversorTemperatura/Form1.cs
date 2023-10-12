using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorTemperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                double temperatura = double.Parse(textBoxTemperatura.Text);
                if (Fahrenheit.Checked)
                {
                    temperatura = (temperatura * 9 / 5) + 32;
                }
                else if (Celsius.Checked)
                {
                    temperatura = (temperatura - 32) * 5 / 9;
                }
                textBoxTemperatura.Text = $"{temperatura}";
            }
            catch (Exception ex)
            {
                textBoxTemperatura.Text = "Error";
            }
        }
    }
}
