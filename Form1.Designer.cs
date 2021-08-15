
namespace TemperatureConverter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFahrenheit = new System.Windows.Forms.TextBox();
            this.textBoxCelsius = new System.Windows.Forms.TextBox();
            this.textBoxKelvin = new System.Windows.Forms.TextBox();
            this.buttonFahrenheit = new System.Windows.Forms.Button();
            this.buttonCelsius = new System.Windows.Forms.Button();
            this.buttonKelvin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fahrenheit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Celsius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelvin";
            // 
            // textBoxFahrenheit
            // 
            this.textBoxFahrenheit.Location = new System.Drawing.Point(75, 11);
            this.textBoxFahrenheit.Name = "textBoxFahrenheit";
            this.textBoxFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.textBoxFahrenheit.TabIndex = 3;
            // 
            // textBoxCelsius
            // 
            this.textBoxCelsius.Location = new System.Drawing.Point(75, 48);
            this.textBoxCelsius.Name = "textBoxCelsius";
            this.textBoxCelsius.Size = new System.Drawing.Size(100, 20);
            this.textBoxCelsius.TabIndex = 4;
            // 
            // textBoxKelvin
            // 
            this.textBoxKelvin.Location = new System.Drawing.Point(75, 91);
            this.textBoxKelvin.Name = "textBoxKelvin";
            this.textBoxKelvin.Size = new System.Drawing.Size(100, 20);
            this.textBoxKelvin.TabIndex = 5;
            // 
            // buttonFahrenheit
            // 
            this.buttonFahrenheit.Location = new System.Drawing.Point(181, 11);
            this.buttonFahrenheit.Name = "buttonFahrenheit";
            this.buttonFahrenheit.Size = new System.Drawing.Size(75, 20);
            this.buttonFahrenheit.TabIndex = 6;
            this.buttonFahrenheit.Text = "Convert";
            this.buttonFahrenheit.UseVisualStyleBackColor = true;
            this.buttonFahrenheit.Click += new System.EventHandler(this.buttonFahrenheit_Click);
            // 
            // buttonCelsius
            // 
            this.buttonCelsius.Location = new System.Drawing.Point(181, 48);
            this.buttonCelsius.Name = "buttonCelsius";
            this.buttonCelsius.Size = new System.Drawing.Size(75, 20);
            this.buttonCelsius.TabIndex = 7;
            this.buttonCelsius.Text = "Convert";
            this.buttonCelsius.UseVisualStyleBackColor = true;
            this.buttonCelsius.Click += new System.EventHandler(this.buttonCelsius_Click);
            // 
            // buttonKelvin
            // 
            this.buttonKelvin.Location = new System.Drawing.Point(181, 91);
            this.buttonKelvin.Name = "buttonKelvin";
            this.buttonKelvin.Size = new System.Drawing.Size(75, 20);
            this.buttonKelvin.TabIndex = 8;
            this.buttonKelvin.Text = "Convert";
            this.buttonKelvin.UseVisualStyleBackColor = true;
            this.buttonKelvin.Click += new System.EventHandler(this.buttonKelvin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 153);
            this.Controls.Add(this.buttonKelvin);
            this.Controls.Add(this.buttonCelsius);
            this.Controls.Add(this.buttonFahrenheit);
            this.Controls.Add(this.textBoxKelvin);
            this.Controls.Add(this.textBoxCelsius);
            this.Controls.Add(this.textBoxFahrenheit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFahrenheit;
        private System.Windows.Forms.TextBox textBoxCelsius;
        private System.Windows.Forms.TextBox textBoxKelvin;
        private System.Windows.Forms.Button buttonFahrenheit;
        private System.Windows.Forms.Button buttonCelsius;
        private System.Windows.Forms.Button buttonKelvin;
    }
}

