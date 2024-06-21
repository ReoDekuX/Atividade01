using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade01.View
{
    public partial class Atividade : Form
    {
        public Atividade()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt16(tbx_valor1.Text);
            int valor2 = Convert.ToInt16(tbx_valor2.Text);
            int soma = valor1 + valor2;

            lbl_responde.Text = soma.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {   
        }
    }
}
