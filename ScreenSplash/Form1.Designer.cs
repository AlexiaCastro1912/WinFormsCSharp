namespace ScreenSplash
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
            this.components = new System.ComponentModel.Container();
            this.pBase = new System.Windows.Forms.Panel();
            this.pLoad = new System.Windows.Forms.Panel();
            this.timeLoad = new System.Windows.Forms.Timer(this.components);
            this.classGradientPanel1 = new GradientPanel_Code.ClassGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pBase.SuspendLayout();
            this.classGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBase
            // 
            this.pBase.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pBase.Controls.Add(this.pLoad);
            this.pBase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBase.Location = new System.Drawing.Point(0, 308);
            this.pBase.Name = "pBase";
            this.pBase.Size = new System.Drawing.Size(800, 22);
            this.pBase.TabIndex = 0;
            // 
            // pLoad
            // 
            this.pLoad.BackColor = System.Drawing.Color.Purple;
            this.pLoad.Location = new System.Drawing.Point(0, -8);
            this.pLoad.Name = "pLoad";
            this.pLoad.Size = new System.Drawing.Size(35, 40);
            this.pLoad.TabIndex = 0;
            // 
            // timeLoad
            // 
            this.timeLoad.Enabled = true;
            this.timeLoad.Interval = 200;
            this.timeLoad.Tick += new System.EventHandler(this.timeLoad_Tick);
            // 
            // classGradientPanel1
            // 
            this.classGradientPanel1.ColorBottom = System.Drawing.Color.Thistle;
            this.classGradientPanel1.ColorTop = System.Drawing.Color.DarkOrchid;
            this.classGradientPanel1.Controls.Add(this.label2);
            this.classGradientPanel1.Controls.Add(this.label1);
            this.classGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.classGradientPanel1.Name = "classGradientPanel1";
            this.classGradientPanel1.Size = new System.Drawing.Size(800, 330);
            this.classGradientPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(229, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Splash Screen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loading...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 330);
            this.Controls.Add(this.pBase);
            this.Controls.Add(this.classGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pBase.ResumeLayout(false);
            this.classGradientPanel1.ResumeLayout(false);
            this.classGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pBase;
        private System.Windows.Forms.Panel pLoad;
        private GradientPanel_Code.ClassGradientPanel classGradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timeLoad;
        private System.Windows.Forms.Label label2;
    }
}

