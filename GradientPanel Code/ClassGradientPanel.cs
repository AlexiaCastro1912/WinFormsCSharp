// SE INCLUYEN LOS ESPACIOS DE LOS NOMBRES BASICOS DE C3, AUNQUE EN ESTE CODIGO ALGUNOS NO SON NECESARIOS YA QUE NO SE USAN.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// SE USAN PARA MANIPULAR GRAFICOS, COLORES Y DEGRADADOS.
using System.Drawing;
using System.Drawing.Drawing2D;

// SE USA PARA TRABAJAR CON FORMULARIOS DE WINDOWS FORM
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

// DEFINE UN NAMESPACE LLAMADO GradientPanel_Code. SIRVE PARA AGRUPAR LAS CLASES Y EVITAR CONFLICTOR DE NOMBRES CON OTRAS CLASES.
namespace GradientPanel_Code
{
    // SE DEFINE UNA CLASE QUE HEREDA DE PANEL. EL PANEL ES UN CONTENEDOR VISUAL DE WINDOWS FORM Y AQUI SE EXTIENDE PARA AGREGAR
    // LA FUNCIONALIDAD DE DEGRADADO.
    class ClassGradientPanel : Panel
    {
        // SE DEFINEN DOS PROPIEDADES DE TIPO COLOR
        // NOTA: SE USAN PROPIEDADES AUTOMATICAS, LO QUE SIGNIFICA QUE C3 MANEJA INTERNAMENTE LOS CAMPOS DE ALMACENAMIENTO.
        public Color ColorTop { get; set; }    // COLOR DE ARRIBA
        public Color ColorBottom { get; set; } // COLOR DE ABAJO

        // SE SOBREESCRIBE EL METODO OnPaint DEL PANEL.
        // ESTE METODO SE EJECUTA AUTOMATICAMENTE CADA VEZ QUE EL CONTROL NECESITA REPINTARSE, POR EJEMPLO,
        // CUANDO SE REDIMENSIONA O SE MUESTRA EN PANTALLA.
        protected override void OnPaint(PaintEventArgs e)
        {
            // LinearGradientBrush ES UN OBJETO QUE CREA UN DEGRADADO DE COLOR.
            // PARAMETROS A DECLARAR:
            // this.ClientRectangle: DEFINE EL AREA DONDE SE APLICARA EL DEGRADADO (TODO EL PANEL).
            // this.ColorTop: COLOR INICIAL DEL DEGRADADO.
            // this.ColorBottom: COLOR FINAL DEL DEGRADADO.
            // 90F: ANGULO DEL DEGRADADO (COMO DICE 90 SERA DE ARRIBA HACIA ABAJO).
            //
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottom, 90F);
            Graphics graph = e.Graphics; // OBTIENE EL OBJETO GRAFICO DONDE SE DIBUJARA EL CONTENIDO DEL PANEL.
            graph.FillRectangle(lgb, this.ClientRectangle); // RELLENA EL PANEL CON EL DEGRADADO.
            base.OnPaint(e); // LLAMA AL METODO OnPaint DE LA CLASE BASE (PANEL) PARA ASEGURARSE DE QUE EL PANEL SE PINTE
                             // CORRECTAMENTE.
        }
    }
}
