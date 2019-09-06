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
    public partial class FormMenu : Form
    {
        string usuario = "";
        string password = "";

        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            FormIngreso frm = new FormIngreso();
            frm.ShowDialog();
            if (frm._usuario == "")
            {
                MessageBox.Show("No es valido ningun Usuario.");
                frm.Dispose();
                return;
            }
            this.usuario = frm._usuario;
            this.password = frm._password;
            frm.Dispose();
            
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            FormInventario frm = new FormInventario();
            frm.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {

        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Boton creado momentaneamente para demostracion de abm usuario
            Form formulario = new form_menuAdm();
            formulario.Show();
        }
    }
}
