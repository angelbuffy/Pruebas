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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Farmaceutico nuevoFarmaceutico = new Farmaceutico(textBox1.Text, textBox2.Text, textBox3.Text,
                    textBox4.Text, textBox5.Text, textBox6.Text);
                nuevoFarmaceutico.Registrar();
            }

            catch (ArgumentNullException error)
            {
                MessageBox.Show("Complete los datos requeridos." + "\n" + error.ParamName, "Demo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                /*textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();*/
                textBox1.SelectAll();
                textBox2.SelectAll();
                textBox3.SelectAll();
                textBox4.SelectAll();
                textBox5.SelectAll();
                textBox6.SelectAll();
                textBox1.Focus();
                textBox2.Focus();
                textBox3.Focus();
                textBox4.Focus();
                textBox5.Focus();
                textBox6.Focus();
                return;
            }

            catch (ArgumentOutOfRangeException error)
            {
                MessageBox.Show(error.ParamName, "Demo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                /*textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();*/
                textBox1.SelectAll();
                textBox2.SelectAll();
                textBox3.SelectAll();
                textBox4.SelectAll();
                textBox5.SelectAll();
                textBox6.SelectAll();
                textBox1.Focus();
                textBox2.Focus();
                textBox3.Focus();
                textBox4.Focus();
                textBox5.Focus();
                textBox6.Focus();
                return;
            }

            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error." + "\n" + "Detalle: " + error.Message, "Demo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                /*textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();*/
                textBox1.SelectAll();
                textBox2.SelectAll();
                textBox3.SelectAll();
                textBox4.SelectAll();
                textBox5.SelectAll();
                textBox6.SelectAll();
                textBox1.Focus();
                textBox2.Focus();
                textBox3.Focus();
                textBox4.Focus();
                textBox5.Focus();
                textBox6.Focus();
                return;
            }

            MessageBox.Show("Inserción completada.", "lex", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox1.Focus();
            textBox2.Focus();
            textBox3.Focus();
            textBox4.Focus();
            textBox5.Focus();
            textBox6.Focus();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Terminando la aplicación
            //Form formulario = new Form2();
            //formulario.Show();
            this.Dispose();
            
        }
    }
}
