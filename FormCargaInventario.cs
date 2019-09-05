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
using MandaleFruta.Modelos;

namespace MandaleFruta
{
    public partial class FormCargaInventario : Form
    {
        FrutasVerdurasRepositorio _frutasVerdurasRepositorio;

        public FormCargaInventario()
        {
            InitializeComponent();
            _frutasVerdurasRepositorio = new FrutasVerdurasRepositorio();
        }
               
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormCargaInventario_Load(object sender, EventArgs e)
        {
            ArrayList listaTipo = new ArrayList();
            listaTipo.Add("Verdura");
            listaTipo.Add("Fruta");
            cmbTipo.DataSource = listaTipo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var producto = new FrutaVerdura();
            producto.Nombre = txtNombre.Text;
            producto.id_FrutaVerdura = Convert.ToInt32(txtArticulo.Text);
            producto.id_Tipo = 0;
            ///producto.id_Tipo = cmbTipo.SelectedIndex;

            if (txtArticulo.Text == "")
            {
                MessageBox.Show("Ingrese un Artículo");
                txtArticulo.Focus();
                return;
            }
            else if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese El Nombre del Artículo");
                txtNombre.Focus();
                return;
            }
            if (_frutasVerdurasRepositorio.Guardar(producto))
            {
                MessageBox.Show("se registro con exito");
                this.Dispose();
            }
            
            this.Close();




        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
