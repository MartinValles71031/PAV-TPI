using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormInventario : Form
    {

        public FormInventario()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormInventario_Load(object sender, EventArgs e)
        {

            ArrayList listaInventario = new ArrayList();
            grdInventario.Columns.Add("clmarticulo", "Artículo");
            grdInventario.Columns.Add("clmnombre", "Nombre");
            grdInventario.Columns.Add("clmcantidad", "Cantidad");
            grdInventario.Columns.Add("clmprecio", "Precio (Kg)");
            grdInventario.Columns.Add("clmdescripcion", "Descripción");
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

            FormCargaInventario frm = new FormCargaInventario();
            frm.ShowDialog();
            if (frm._articulo == "")
            {
                return;
            }
            else
            {
                grdInventario.Rows.Add(frm._articulo, frm._nombre.ToUpper(), frm._cantidad, frm._precio, frm._descripcion);

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            grdInventario.Rows.Clear();
                         
        }
    }
}
