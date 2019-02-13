using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciosWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mitF01_Click(object sender, EventArgs e)
        {
            F01 formulario = new F01();
            //formulario.MdiParent = this;
            formulario.Text = "Exercicios F - 01";
            formulario.Show();
        }

        private void mitH01_Click(object sender, EventArgs e)
        {
            H01 formulario = new H01();
            formulario.Text = "Exercicio H - 01";
            formulario.Show();
        }

        private void mitH02_Click(object sender, EventArgs e)
        {
            H02 formulario = new H02();
            formulario.Text = "Exercicio H - 02";
            formulario.Show();
        }

        private void mitH04_Click(object sender, EventArgs e)
        {
            H04 formulario = new H04();
            formulario.Text = "Exercicio H - 04";
            formulario.Show();
        }

        private void mitSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
