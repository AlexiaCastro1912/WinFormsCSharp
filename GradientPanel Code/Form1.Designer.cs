﻿namespace GradientPanel_Code
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
            this.classGradientPanel1 = new GradientPanel_Code.ClassGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.classGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // classGradientPanel1
            // 
            this.classGradientPanel1.ColorBottom = System.Drawing.Color.SteelBlue;
            this.classGradientPanel1.ColorTop = System.Drawing.Color.Violet;
            this.classGradientPanel1.Controls.Add(this.label3);
            this.classGradientPanel1.Controls.Add(this.label2);
            this.classGradientPanel1.Controls.Add(this.label1);
            this.classGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.classGradientPanel1.Name = "classGradientPanel1";
            this.classGradientPanel1.Size = new System.Drawing.Size(800, 450);
            this.classGradientPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ing Alexia del Carmen Castro Vazquez";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(599, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bloque de codigo para implementar degradado a un panel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(761, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.classGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.classGradientPanel1.ResumeLayout(false);
            this.classGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ClassGradientPanel classGradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

