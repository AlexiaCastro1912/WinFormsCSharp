using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_ComboBox
{
    public partial class frmIndex: Form
    {
        public frmIndex()
        {
            InitializeComponent();
        }

        // DECLARACION DE VARIABLES
        string vSeleccion;
        int vSelect = 0; // VARIABLE PARA OBTENER EL INDICE AL DAR CLIC SOBRE EL ELEMENTO EN EL DATAGRIDVIEW

        // CARGAR ELEMENTOS CUANDO EL FORMULARIO EJECUTA
        private void frmIndex_Load(object sender, EventArgs e)
        {
            // AGREGAMOS ELEMENTOS AL COMBOBOX DESDE CODIGO PARA QUE ESTOS CARGUEN AL MOMENTO DE EJECUTAR
            // EL FORMULARIO
            cbobxPais.Items.Add("Mexico");
            cbobxPais.Items.Add("Estados Unidos");
            cbobxPais.Items.Add("Canada");
            cbobxPais.Items.Add("Peru");
            cbobxPais.Items.Add("Argentina");
            cbobxPais.Items.Add("Republica Dominicana");
            cbobxPais.Items.Add("Colombia");
            cbobxPais.Items.Add("Ecuador");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // EN LA VARIABLE ALMACENAMOS EL TEXTO SELECCIONADO DEL COMBOBOX EN FORMATO STRING
            vSeleccion = Convert.ToString(cbobxPais.Text);

            // ADICIONAMOS NUEVO RENGLON
            int vIndice = dgvDatos.Rows.Add();

            // AGREGAMOS LOS DATOS AL DATAGRIDVIEW
            dgvDatos.Rows[vIndice].Cells[0].Value = txtNombre.Text;
            dgvDatos.Rows[vIndice].Cells[1].Value = txtApellido.Text;
            //dgvDatos.Rows[vIndice].Cells[1].Value = cbobxPais.Text; // FORMA INCORRECTA PARA AGREGAR EL ELEMENTO
            dgvDatos.Rows[vIndice].Cells[2].Value = vSeleccion; // FORMA CORRECTA PARA AGREGAR EL ELEMENTO

            // LIMPIAMOS LAS CAJAS DE TEXTO
            txtNombre.Text = "";
            txtApellido.Text = "";
            cbobxPais.Text = "";

        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // ALMACENAMOS EN LA VARIABLE vSelect LA INFORMACION DEL INDICE DEL RENGLON EN EL CUAL SE LLEVO A CABO DICHO CLIC.
            // UTILIZAMOS EL PARAMETRO e QUE CONTIENE INFORMACION ACERCA DEL EVENTO QUE ESTAMOS MANEJANDO.
            vSelect = e.RowIndex;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // CONDICION PARA EVALUAR QUE EL ELEMENTO AL QUE SE LE DIO CLIC NO ES EL ENCABEZADO YA QUE EL INDICE DEL ENCABEZADO
            // TIENE UN VALOR DE 0 Y ES UN INDICE QUE NO NOS INTERESA ALMACENAR, POR LO QUE NECESITAMOS CONDICIONAR QUE EL VALOR NO SEA 0
            // PARA PROCEDER A ELIMINARLO DE LO CONTRARIO MOSTRAMOS UN MENSAJE DE ERROR.
            if (vSelect != -1)
            {
                dgvDatos.Rows.RemoveAt(vSelect);
            }
            else
            {
                MessageBox.Show("Elemento seleccionado incorrecto");
            }
        }
    }
}
