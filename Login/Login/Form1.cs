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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Meliton" && textBox2.Text == "123")
            {
                MessageBox.Show("Se a iniciado sesision");
                this.Hide();
                Form2 vetana = new Form2();
                vetana.Show();
            }//aqui terminar if
            else
            {
                MessageBox.Show("Error en el usuario o contraseña");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
                
             }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

