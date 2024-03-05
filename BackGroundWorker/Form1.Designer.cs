namespace BackGroundWorker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            progressBar = new ProgressBar();
            load = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 80);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(371, 54);
            progressBar.TabIndex = 0;
            // 
            // load
            // 
            load.Location = new Point(12, 190);
            load.Name = "load";
            load.Size = new Size(371, 59);
            load.TabIndex = 1;
            load.Text = "Cargar";
            load.UseVisualStyleBackColor = true;
            load.Click += load_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 320);
            Controls.Add(load);
            Controls.Add(progressBar);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            Text = "BackGround";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar;
        private Button load;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
