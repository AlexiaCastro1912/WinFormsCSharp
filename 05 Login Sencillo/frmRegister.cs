using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _05_Login_Sencillo
{
    public partial class frmRegister: Form
    {
        private bool vShowPass = false; //Variable para condicionar si se vera o no el password

        public frmRegister()
        {
            InitializeComponent();
        }

        // ============ M E T O D O S ==============
        public void funRegistro()
        {
            // Creamos la liga de conexion entre nuestro servidor y VS
            SqlConnection conexion = new SqlConnection(@"server=MSI\SQLEXPRESS ; database = dbLogin ; INTEGRATED SECURITY = true");
            conexion.Open(); // Abrimos la conexion

            // Creamos un ojeto que es el que se encargara de crear la sentencia SQL con la que seleccionaremos todos los datos para poder evaluar los datos ingresados
            string vConsultaSQL = "INSERT INTO tblUsuarios (Usuario, Contrasena) VALUES ('" + txtUsername.Text.Trim() + "', '" + txtPassword.Text.Trim() + "')";
            SqlCommand cmdRegistro = new SqlCommand(vConsultaSQL, conexion);
            
            cmdRegistro.ExecuteNonQuery();
            conexion.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            funRegistro();
            if(txtConfirmPass.Text == txtPassword.Text)
            {
                MessageBox.Show("You've signed a new user", "NEW REGISTER", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("You've entered incorrect login details", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lklblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin Login = new frmLogin();
            Login.Show();
            this.Hide();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "example@domain.com")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "example@domain.com";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void pbShowHide_Click(object sender, EventArgs e)
        {
            vShowPass = !vShowPass;

            if (vShowPass)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPass.PasswordChar = '\0';
                pbShowHide.Image = _05_Login_Sencillo.Properties.Resources.hide;
            }
            else
            {
                txtPassword.PasswordChar = '×';
                txtConfirmPass.PasswordChar = '×';
                pbShowHide.Image = _05_Login_Sencillo.Properties.Resources.show;
            }
        }
    }
}
