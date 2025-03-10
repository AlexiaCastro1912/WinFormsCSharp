using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace _05_Login_Sencillo
{
    public partial class frmLogin: Form
    {
        // ========== DECLARACION DE VARIABLES
        private bool vShowPass = false; //Variable para condicionar si se vera o no el password

        public frmLogin()
        {
            InitializeComponent();
        }

        // ============ M E T O D O S ==============
        public void login()
        {
            // Creamos la liga de conexion entre nuestro servidor y VS
            SqlConnection conexion = new SqlConnection(@"server=MSI\SQLEXPRESS ; database = dbLogin ; INTEGRATED SECURITY = true");
            conexion.Open(); // Abrimos la conexion

            // Creamos un ojeto que es el que se encargara de crear la sentencia SQL con la que seleccionaremos todos los datos para poder evaluar los datos ingresados
            SqlCommand cmd = new SqlCommand("SELECT Usuario, Contrasena FROM tblUsuarios WHERE Usuario = @vUsuario AND Contrasena = @vContrasena", conexion);
            cmd.Parameters.AddWithValue("@vUsuario", txtUsername.Text.Trim()); // El trim se encarga de eliminar todo espacio en blanco que haya despues del texto
            cmd.Parameters.AddWithValue("@vContrasena", txtPassword.Text.Trim());

            // Lector para buscar los datos en la base de datos
            SqlDataReader Lector = cmd.ExecuteReader(); // Repasar toda la tabla buscando los datos que se estan evaluando

            // Condicion para evaluar si los datos encontrados son correctos
            if (Lector.Read())
            {
                conexion.Close(); // Cerramos la base de datos
                MessageBox.Show("Login Exitoso");
                frmIndex Index = new frmIndex(); // Creamos una instancia al formulario que queremos abrir (objeto)
                Index.Show(); // Mostrarmos el formulario creado - frmIndex
                this.Hide(); // Ocultamos formulario actual
            }
            else
            {
                MessageBox.Show("You've entered incorrect login details", "ERROR", MessageBoxButtons.OK);
            }
        }

        // CODIGOS PARA FUNCIONALIDAD DEL PROGRAMA
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Mandamos a llamar la funcion creada de la conexion
            login();
        }


        // Codigo para abrir otro formulario
        private void lklblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister Register = new frmRegister(); // Creamos una instancia al formulario que queremos abrir  (objeto)
            Register.Show(); // Mostrarmos el formulario creado - frmRegister
            this.Hide(); // Ocultamos formulario actual
        }

        // CODIGOS ESTETICOS PARA EL PROGRAMA
        
        // Evento para aplicar codigo a los textos que entren a dicho control
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            // Condicion para decirle al sistema que si el texto de la TextBox es igual a example@domain.com
            // entonces borrara el texto y el nuevo texto se escribira con negro
            if (txtUsername.Text == "example@domain.com")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        // evento para aplicar codigo a los textos cuando soltamos el control
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            // Condicion para decirle al sistema que si el texto de la TextBox es igual a nada
            // entonces pondra ne nuevo el texto example@domain.com y lo pondra en color gris.
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "example@domain.com";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void pbPassword_Click(object sender, EventArgs e)
        {
            vShowPass = !vShowPass;

            if(vShowPass)
            {
                txtPassword.PasswordChar = '\0';
                pbPassword.Image = _05_Login_Sencillo.Properties.Resources.hide;
            }
            else 
            {
                txtPassword.PasswordChar = '×';
                pbPassword.Image = _05_Login_Sencillo.Properties.Resources.show;
            }
        }
    }
}
