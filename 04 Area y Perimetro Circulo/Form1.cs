using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Area_y_Perimetro_Circulo
{
    public partial class frmIndex: Form
    {
        // INICIALIZAMOS VARIABLES
        double vArea, vPerimetro;

        public frmIndex()
        {
            InitializeComponent();
        }

        private void btnCalcA_Click(object sender, EventArgs e)
        {
            // CALCULAR AREA DE LA FORMA BASICA
            //vArea = 3.1416 * (Convert.ToDouble(txtMedida.Text) * Convert.ToDouble(txtMedida.Text));

            //CALCULAR AREA USANDO CLASE MATH
            // Libreria Math: Contiene Funciones para realizar calculos matematicos.
            // Metodo Pow: Eleva un numero. Primer parametro es la variable u objeto, segundo parametro el numero elevado
            // Metodo PI: Contiene el valor de PI (3.1416)
            vArea = Math.PI * Math.Pow(Convert.ToDouble(txtMedida.Text), 2);
            MessageBox.Show("El area del circulo es: " + vArea, "Area"); //MOSTRAMOS RESULTADO EN MESSAGEBOX
        }

        private void btnCalcP_Click(object sender, EventArgs e)
        {
            // OBTENER EL PERIMETRO DEL CIRCULO
            vPerimetro = 2 * (Math.PI * Convert.ToDouble(txtMedida.Text));
            MessageBox.Show("El perimetro del circulo es: " + vPerimetro, "Perimetro"); //MOSTRAMOS RESULTADO EN MESSAGEBOX
        }
    }
}
