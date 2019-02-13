using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)//Botao -
        {
            double resultado = Convert.ToDouble(txtValor1.Text) - Convert.ToDouble(txtValor2.Text);
            txtResultado.Text = resultado.ToString() ;

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)//Botao *
        {
            double resultado = Convert.ToDouble(txtValor1.Text) * Convert.ToDouble(txtValor2.Text);
            txtResultado.Text = resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)//Botao /
        {
            double resultado = Convert.ToDouble(txtValor1.Text) / Convert.ToDouble(txtValor2.Text);
            txtResultado.Text = resultado.ToString();
        }

        private void btnSomar_Click(object sender, EventArgs e)//Botao +
        {
            double resultado = Convert.ToDouble(txtValor1.Text) + Convert.ToDouble(txtValor2.Text);
            txtResultado.Text = resultado.ToString();
        }

        private void lblTitulo_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);
            //e.Graphics.DrawLine(pen, 20, 10, 300, 100);
            e.Graphics.DrawRectangle(pen,0,90,300,15);
        }
    }
}
