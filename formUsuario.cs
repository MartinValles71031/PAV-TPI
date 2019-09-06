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
    public partial class form_menuAdm : Form
    {
        public form_menuAdm()
        {
            InitializeComponent();
        }

        private void form_menuAdm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Este metodo redirige a otro formulario para registro de nuevo usuario
            Form formulario = new formNuevoUsuario();
            formulario.Show();
        }
    }
}
