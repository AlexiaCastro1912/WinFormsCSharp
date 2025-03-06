using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenSplash
{
    public partial class frmLoaded: Form
    {
        public frmLoaded()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); // FINALIZAMOS LA EJECUCION DEL SISTEMA
        }
    }
}
