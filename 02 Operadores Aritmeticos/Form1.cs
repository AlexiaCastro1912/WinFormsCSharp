using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Operadores_Aritmeticos
{
    public partial class Form1: Form
    {
        /// INICIALIZAMOS VARIABLES
        int vResultado;

        ///  CLASE DEL FORMULARIO
        public Form1()
        {
            InitializeComponent();

            
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            /// CAMBIAMOS EL TEXTO DEL LABEL AL SIGNO ARITMETICO DE SUMA
            lblSigno.Text = "+";

            /// ESTA LINEA SOLO CONCATENA LOS TEXTOS QUE HAY EN CADA CAJA DE TEXTO
            // lblResult.Text = txtNum1.Text + txtNum2.Text;

            /// PARA CONVERTIR EL VALOR STRING A INTEGER DE LAS CAJAS DE TEXTO NECESITAMOS CREAR UNA VARIABLE DE TIPO ENTERO PARA ALMACENAR DICHO VALOR.
            /// UTILIZAMOS EL METODO CONVERT PARA CONVERTIR EL VALOR INGRESADO EN LAS CAJAS DE TEXTO, QUE SON CADENAS, A NUMERO, ESTO EN CADA UNA DE LAS CAJAS.
            /// SEGUIDO MOSTRAMOS EN UN LABEL EL RESULTADO ALMACENADO EN LA VARIABLE Y LO CONVERTIMOS A CADENA DE TEXTO CON TOSTRING.
            vResultado = Convert.ToInt32(txtNum1.Text) + Convert.ToInt32(txtNum2.Text);
            lblResult.Text = vResultado.ToString();
        }

        /// BOTON PARA REALIZAR UNA RESTA
        private void btnResta_Click(object sender, EventArgs e)
        {
            lblSigno.Text = "-";

            vResultado = Convert.ToInt32(txtNum1.Text) - Convert.ToInt32(txtNum2.Text);
            lblResult.Text = vResultado.ToString();
        }

        /// BOTON PARA REALIZAR UNA MULTIPLICACION
        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            lblSigno.Text = "x";

            vResultado = Convert.ToInt32(txtNum1.Text) * Convert.ToInt32(txtNum2.Text);
            lblResult.Text = vResultado.ToString();
        }

        /// BOTON PARA REALIZAR UNA DIVISION
        private void btnDivision_Click(object sender, EventArgs e)
        {
            lblSigno.Text = "/";

            vResultado = Convert.ToInt32(txtNum1.Text) / Convert.ToInt32(txtNum2.Text);
            lblResult.Text = vResultado.ToString();
        }

        /// BOTON PARA LIMPIAR TODOS LOS CAMPOS
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            lblResult.Text = "000";
            lblSigno.Text = "|";
        }

        /// BOTON PARA CERRAR EL FORMULARIO. THIS HACE REFERENCIA A SI MISMO.
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
