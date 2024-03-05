using System.ComponentModel;

namespace BackGroundWorker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void load_Click(object sender, EventArgs e)
        {
            //loadNoBackground();
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync(); // Inicia la operación en segundo plano
            }
        }
        private void loadNoBackground() {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(50); // Simula un trabajo que tarda un tiempo en completarse
                progressBar.Value = i;
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Simula una tarea que lleva tiempo, como cargar datos
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(50); // Simula un trabajo que tarda un tiempo en completarse
                backgroundWorker1.ReportProgress(i); // Reporta el progreso
            }
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage; // Actualiza la ProgressBar con el progreso actual
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Carga completada!"); // Muestra un mensaje al finalizar la carga
        }

    }
}
