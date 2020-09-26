using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia_Final
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Salir_Principal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Registro_FarmaceuticosP_Click(object sender, EventArgs e)
        {
            Form formulario = new Form1();
            formulario.Show();
        }
    }
}
