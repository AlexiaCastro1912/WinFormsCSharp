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
    public partial class frmLogin: Form
    {
        private bool vShowPass = false; //Variable para condicionar si se vera o no el password

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Condicion para evaluar los parametros para poder tener acceso al login
            if(txtUsername.Text == "Admin" && txtPasswrod.Text == "admin")
            {
                frmIndex Index = new frmIndex(); //Creamos una instancia al formulario que queremos abrir (objeto)
                Index.Show(); //Mostramos Formulario Index de Accesor
                this.Hide(); //Ocultamos formulario actual
            }
            else
            {
                MessageBox.Show("You've entered incorrect login details", "ERROR", MessageBoxButtons.OK);
            }
        }
    }
}
