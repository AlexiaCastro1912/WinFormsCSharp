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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // BLOQUE DE CODIGO PARA QUE EL TIMER EVALUE LOS PARAMETROS DEL PANEL Y PUEDA INCREMENTAR
        // EL TAMANO DE ESTE AL CUMPLIR CIERTAS CONDICIONES
        private void timeLoad_Tick(object sender, EventArgs e)
        {
            pLoad.Width += 35; // MEDIDA INICIAL DEL PANEL
            timeLoad.Start(); // INICIALIZAMOS TIMER

            // SI EL PANEL LLEGA A UNA ANCHURA DE 800 PX SE DETENDRA EL TIMER
            if(pLoad.Width >= 800)
            {
                timeLoad.Stop(); // DETENEMOS EL TIMER

                frmLoaded frmLoaded = new frmLoaded(); // CREAMOS INSTANCIA DEL SEGUNDO FORMULARIO
                frmLoaded.Show(); // MOSTRAMOS FORMULARIO 2
                this.Hide(); // OCULTAMOS FORMULARIO ACTUAL
            }
        }
    }
}
