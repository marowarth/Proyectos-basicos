
namespace Cronometro
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
            this.components = new System.ComponentModel.Container();
            this.labelTiempo = new System.Windows.Forms.Label();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.buttonDetener = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelTiempo
            // 
            this.labelTiempo.AutoSize = true;
            this.labelTiempo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTiempo.Location = new System.Drawing.Point(134, 47);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelTiempo.Size = new System.Drawing.Size(28, 32);
            this.labelTiempo.TabIndex = 0;
            this.labelTiempo.Text = "0";
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonIniciar.Location = new System.Drawing.Point(32, 131);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(114, 136);
            this.buttonIniciar.TabIndex = 1;
            this.buttonIniciar.Text = "Start";
            this.buttonIniciar.UseVisualStyleBackColor = true;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonIniciar_Click);
            // 
            // buttonDetener
            // 
            this.buttonDetener.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDetener.Location = new System.Drawing.Point(152, 131);
            this.buttonDetener.Name = "buttonDetener";
            this.buttonDetener.Size = new System.Drawing.Size(114, 136);
            this.buttonDetener.TabIndex = 2;
            this.buttonDetener.Text = "Stop";
            this.buttonDetener.UseVisualStyleBackColor = true;
            this.buttonDetener.Click += new System.EventHandler(this.buttonDetener_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 301);
            this.Controls.Add(this.buttonDetener);
            this.Controls.Add(this.buttonIniciar);
            this.Controls.Add(this.labelTiempo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTiempo;
        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.Button buttonDetener;
        private System.Windows.Forms.Timer timer;
    }
}

