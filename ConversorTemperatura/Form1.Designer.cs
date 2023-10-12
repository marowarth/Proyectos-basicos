
namespace ConversorTemperatura
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
            this.textBoxTemperatura = new System.Windows.Forms.TextBox();
            this.Fahrenheit = new System.Windows.Forms.RadioButton();
            this.Celsius = new System.Windows.Forms.RadioButton();
            this.buttonConvertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTemperatura
            // 
            this.textBoxTemperatura.Location = new System.Drawing.Point(12, 33);
            this.textBoxTemperatura.Name = "textBoxTemperatura";
            this.textBoxTemperatura.Size = new System.Drawing.Size(254, 23);
            this.textBoxTemperatura.TabIndex = 0;
            // 
            // Fahrenheit
            // 
            this.Fahrenheit.AutoSize = true;
            this.Fahrenheit.Location = new System.Drawing.Point(82, 75);
            this.Fahrenheit.Name = "Fahrenheit";
            this.Fahrenheit.Size = new System.Drawing.Size(36, 19);
            this.Fahrenheit.TabIndex = 1;
            this.Fahrenheit.TabStop = true;
            this.Fahrenheit.Text = "Fº";
            this.Fahrenheit.UseVisualStyleBackColor = true;
            // 
            // Celsius
            // 
            this.Celsius.AutoSize = true;
            this.Celsius.Location = new System.Drawing.Point(12, 75);
            this.Celsius.Name = "Celsius";
            this.Celsius.Size = new System.Drawing.Size(38, 19);
            this.Celsius.TabIndex = 2;
            this.Celsius.TabStop = true;
            this.Celsius.Text = "Cº";
            this.Celsius.UseVisualStyleBackColor = true;
            // 
            // buttonConvertir
            // 
            this.buttonConvertir.Location = new System.Drawing.Point(12, 110);
            this.buttonConvertir.Name = "buttonConvertir";
            this.buttonConvertir.Size = new System.Drawing.Size(254, 60);
            this.buttonConvertir.TabIndex = 3;
            this.buttonConvertir.Text = "Convertir";
            this.buttonConvertir.UseVisualStyleBackColor = true;
            this.buttonConvertir.Click += new System.EventHandler(this.buttonConvertir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 204);
            this.Controls.Add(this.buttonConvertir);
            this.Controls.Add(this.Celsius);
            this.Controls.Add(this.Fahrenheit);
            this.Controls.Add(this.textBoxTemperatura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTemperatura;
        private System.Windows.Forms.RadioButton Fahrenheit;
        private System.Windows.Forms.RadioButton Celsius;
        private System.Windows.Forms.Button buttonConvertir;
    }
}

