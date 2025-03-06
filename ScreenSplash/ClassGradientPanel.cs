using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// LIBRERIAS DEL SISTEMA PARA MANEJAR LAS PROPIEDADES DE DIBUJO Y DEGRADAR CONTROL
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GradientPanel_Code
{
    // CLASE QUE LE AFECTARA A TODO CONTROL DE TIPO... (PANEL)
    class ClassGradientPanel : Panel
    {
        // CREAMOS VARIABLES QUE OBTENDRAN LOS VALORES DADOS DESDE PROPIEDADES
        public Color ColorTop { get; set; }    // COLOR DE ARRIBA
        public Color ColorBottom { get; set; } // COLOR DE ABAJO

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottom, 90F);
            Graphics graph = e.Graphics;
            graph.FillRectangle(lgb, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
