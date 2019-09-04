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
    public partial class FormCargaInventario : Form
    {
        public FormCargaInventario()
        {
            InitializeComponent();
        }
        public string _articulo
        {
            get { return this.txtArticulo.Text; }
            set { this.txtArticulo.Text = value; }
        }
        public string _nombre
        {
            get { return this.txtNombre.Text; }
            set { this.txtNombre.Text = value; }
        }
        public string _codTipo
        {
            get { return this.cmbTipo.SelectedIndex.ToString(); }
            //set { this.cmbTipo.SelectedIndex = value; }
        }

        public string _Tipo
        {
            get { return this.cmbTipo.Text; }
            set { this.cmbTipo.Text = value; }
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
