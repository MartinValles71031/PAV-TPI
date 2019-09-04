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
            grdInventario.Columns.Add("clmtipo", "Tipo");
            grdInventario.Columns.Add("clmclavetipo", "Codigo tipo");
            grdInventario.Columns[3].Visible = false;
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
                grdInventario.Rows.Add(frm._articulo, frm._nombre.ToUpper(), frm._Tipo);

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            grdInventario.Rows.RemoveAt(grdInventario.CurrentRow.Index);
            

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormCargaInventario frm = new FormCargaInventario();
            //var array = grdInventario.CurrentRow.Index()
            frm.ShowDialog();
            grdInventario.Rows.Insert(grdInventario.CurrentRow.Index);
        
        }
    }
}
