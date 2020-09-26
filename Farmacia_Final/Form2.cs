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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Ingresar_Login_Click(object sender, EventArgs e)
        {
            if (Login.Validar(textBoxLogin.Text, textBoxContra.Text)==null)
            {
                MessageBox.Show("Error: El usuario o la contraseña ingresada no son correctas");
            }

            else
            {

                this.Hide();
                MessageBox.Show("Bienvenido!");
                Form formulario = new Principal();
                formulario.Show();
                
            }

        }

        private void Cancelar_Login_Click(object sender, EventArgs e)
        {
            //Terminando la aplicación
            Application.Exit();
        }
    }
}
