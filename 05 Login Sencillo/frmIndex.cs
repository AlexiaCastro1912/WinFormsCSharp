using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_Login_Sencillo
{
    public partial class frmIndex: Form
    {
        public frmIndex()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmLogin Login = new frmLogin(); //Creamos una instancia (objeto) al fomrulario login
            Login.Show(); //Mostramos el formulario login
            this.Hide(); //Ocultamos el formulario actual

        }
    }
}
