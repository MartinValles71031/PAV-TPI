using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MandaleFruta
{
    public partial class formMenuInventario : Form
    {
        public formMenuInventario()
        {
            InitializeComponent();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            //abre abm con tabla de artículos
            FormInventario frm = new FormInventario();
            frm.ShowDialog();
        }

        private void frmMenuInventario_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTipoArticulo_Click(object sender, EventArgs e)
        {
            formTipoArt frm = new formTipoArt();
            frm.ShowDialog();
        }
    }
}
