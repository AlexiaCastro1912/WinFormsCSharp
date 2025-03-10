namespace ColorSections_Code
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
            this.pBanner = new System.Windows.Forms.Panel();
            this.pMenu = new System.Windows.Forms.Panel();
            this.pPadre = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pBanner
            // 
            this.pBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBanner.Location = new System.Drawing.Point(0, 0);
            this.pBanner.Name = "pBanner";
            this.pBanner.Size = new System.Drawing.Size(943, 56);
            this.pBanner.TabIndex = 0;
            // 
            // pMenu
            // 
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 56);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(178, 487);
            this.pMenu.TabIndex = 1;
            // 
            // pPadre
            // 
            this.pPadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPadre.Location = new System.Drawing.Point(178, 56);
            this.pPadre.Name = "pPadre";
            this.pPadre.Size = new System.Drawing.Size(765, 487);
            this.pPadre.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 543);
            this.Controls.Add(this.pPadre);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.pBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pBanner;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Panel pPadre;
    }
}

