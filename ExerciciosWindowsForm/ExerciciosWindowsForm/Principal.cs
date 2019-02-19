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
    public partial class Principal : Form
    {
        public Principal()
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

        private void mitSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void t11ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            T11 frame = new T11();
            frame.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            T13 frame = new T13();
            frame.Show();

        }
    }
}
