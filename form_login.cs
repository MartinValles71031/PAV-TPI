using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MandaleFruta
{
    public partial class FormIngreso : Form
    {
        public string _usuario
        {
            get { return this.TxtUsuario.Text; }
            set { this.TxtUsuario.Text = value; }
        }
        public string _password
        {
            get { return this.TxtPass.Text; }
            set { this.TxtPass.Text = value; }
        }


        public FormIngreso()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            //Valida que el campo usuario tenga algo escrito
            if (TxtUsuario.Text == "")
            {
                MessageBox.Show("Ingrese un Usuario");
                this.TxtUsuario.Focus();
                return;
            }
            //Valida que el campo contraseña tenga algo escrito
            if (TxtPass.Text == "")
            {
                MessageBox.Show("Ingrese una Contraseña");
                this.TxtPass.Focus();
                return;
            }
            this.Close();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
