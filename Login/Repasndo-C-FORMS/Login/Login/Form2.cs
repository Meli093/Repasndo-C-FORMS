using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //vamoa a poner nuestro conteo.
            int cont = 0;
            string seleccion;

            if (checkBox1.Checked == true)
            {
                cont ++;
            }
            if (checkBox2.Checked == true)
            {
                cont++;
            }
            if (radioButton1.Checked == true)
            {
                seleccion = "Tarjeta de credito";
            }
            else
            {
                seleccion = "paypal";
            }
            MessageBox.Show("has seleccionado" + cont + "el curso y el pago es:" + seleccion);
        }
        }
    }
}
