namespace _03_Celsius_a_Fahrenheit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConvertF = new System.Windows.Forms.Button();
            this.btnConvertC = new System.Windows.Forms.Button();
            this.lblResF = new System.Windows.Forms.Label();
            this.lblResC = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.lblResF);
            this.panel1.Controls.Add(this.btnConvertF);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCelsius);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 200);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.lblResC);
            this.panel2.Controls.Add(this.btnConvertC);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtFahrenheit);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 200);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CELSIUS A FAHRENHEIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "FAHRENHEIT A CELSIUS";
            // 
            // txtCelsius
            // 
            this.txtCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelsius.Location = new System.Drawing.Point(17, 107);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(152, 27);
            this.txtCelsius.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(13, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "FORMULA: (Fahrenheit − 32) × 5/9 =  °C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(13, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "FORMULA: (Celsius × 9/5) + 32 = °F";
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFahrenheit.Location = new System.Drawing.Point(17, 107);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(152, 27);
            this.txtFahrenheit.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ingrese Celsius";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ingrese Fahrenheit";
            // 
            // btnConvertF
            // 
            this.btnConvertF.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnConvertF.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnConvertF.FlatAppearance.BorderSize = 3;
            this.btnConvertF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertF.ForeColor = System.Drawing.Color.Black;
            this.btnConvertF.Location = new System.Drawing.Point(198, 89);
            this.btnConvertF.Name = "btnConvertF";
            this.btnConvertF.Size = new System.Drawing.Size(120, 61);
            this.btnConvertF.TabIndex = 2;
            this.btnConvertF.Text = "CONVERTIR";
            this.btnConvertF.UseVisualStyleBackColor = false;
            // 
            // btnConvertC
            // 
            this.btnConvertC.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnConvertC.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnConvertC.FlatAppearance.BorderSize = 3;
            this.btnConvertC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertC.Location = new System.Drawing.Point(198, 91);
            this.btnConvertC.Name = "btnConvertC";
            this.btnConvertC.Size = new System.Drawing.Size(120, 61);
            this.btnConvertC.TabIndex = 2;
            this.btnConvertC.Text = "CONVERTIR";
            this.btnConvertC.UseVisualStyleBackColor = false;
            // 
            // lblResF
            // 
            this.lblResF.AutoSize = true;
            this.lblResF.BackColor = System.Drawing.Color.Black;
            this.lblResF.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResF.ForeColor = System.Drawing.Color.Lime;
            this.lblResF.Location = new System.Drawing.Point(367, 107);
            this.lblResF.Name = "lblResF";
            this.lblResF.Size = new System.Drawing.Size(104, 36);
            this.lblResF.TabIndex = 3;
            this.lblResF.Text = "122 °F";
            // 
            // lblResC
            // 
            this.lblResC.AutoSize = true;
            this.lblResC.BackColor = System.Drawing.Color.Black;
            this.lblResC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResC.ForeColor = System.Drawing.Color.Lime;
            this.lblResC.Location = new System.Drawing.Point(367, 109);
            this.lblResC.Name = "lblResC";
            this.lblResC.Size = new System.Drawing.Size(90, 36);
            this.lblResC.TabIndex = 3;
            this.lblResC.Text = "10 °C";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(364, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Resultado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(364, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(500, 407);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Sistema de Conversion de Grados";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.Label lblResF;
        private System.Windows.Forms.Button btnConvertF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConvertC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblResC;
        private System.Windows.Forms.Label label10;
    }
}

