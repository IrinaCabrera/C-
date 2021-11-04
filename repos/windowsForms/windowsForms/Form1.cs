using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsForms
{
    public partial class Form1 : Form
    {

        public Form1()

        {

            InitializeComponent();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            try

            {
                double suma = double.Parse(textBox6.Text ) + double.Parse(textBox7.Text);

                textBox8.Text = textBox6.Text +" + "+ textBox7.Text;

                textBox9.Text = suma.ToString();
            }

            catch (Exception )

            {

                //mostrara un mensage si lo introducido

                //es diferente de un numero

                

            }
        }
    }
}
