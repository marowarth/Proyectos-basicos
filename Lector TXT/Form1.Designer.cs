
namespace Lector_TXT
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
            this.textBoxContenido = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxContenido
            // 
            this.textBoxContenido.Location = new System.Drawing.Point(46, 105);
            this.textBoxContenido.Multiline = true;
            this.textBoxContenido.Name = "textBoxContenido";
            this.textBoxContenido.ReadOnly = true;
            this.textBoxContenido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxContenido.Size = new System.Drawing.Size(716, 290);
            this.textBoxContenido.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Abrir fichero";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonAbrir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxContenido);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxContenido;
        private System.Windows.Forms.Button button1;
    }
}

