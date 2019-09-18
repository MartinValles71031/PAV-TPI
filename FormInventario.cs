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
using MandaleFruta.repositorios;

namespace MandaleFruta
{
    public partial class FormInventario : Form
    {
        FrutasVerdurasRepositorio _frutasVerdurasRepositorio;

        public FormInventario()
        {
            InitializeComponent();
            _frutasVerdurasRepositorio = new FrutasVerdurasRepositorio();
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

            ActualizarInventario();
        }
        private void ActualizarInventario()
        {
            grdInventario.Rows.Clear();
            var inventario = _frutasVerdurasRepositorio.obtenerFrutasVerdurasDT().Rows;
            ActualizarGrilla(inventario);

        }
        private void ActualizarGrilla(DataRowCollection registros)
        {
            foreach (DataRow registro in registros)
            {
                if (registro.HasErrors)
                    continue;
                var fila = new String[]
                {
                    registro.ItemArray[0].ToString(),
                    registro.ItemArray[1].ToString(),
                    registro.ItemArray[2].ToString()

                };
                grdInventario.Rows.Add(fila);
            }
        }


        private void btnCargar_Click(object sender, EventArgs e)
        {

            FormCargaInventario frm = new FormCargaInventario();
            frm.ShowDialog();
            
            

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            grdInventario.Rows.RemoveAt(grdInventario.CurrentRow.Index);
            

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormCargaInventario frm = new FormCargaInventario();
            //var array = grdInventario.CurrentRow.Index()
            this.Hide();
            frm.ShowDialog();
            grdInventario.Rows.Insert(grdInventario.CurrentRow.Index);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
