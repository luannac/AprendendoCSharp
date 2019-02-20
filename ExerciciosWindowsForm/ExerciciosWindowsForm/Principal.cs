using F4;
using T12;
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

        private void f04ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F04 frame = new F04();
            frame.Show();
        }

        private void t12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            T12.T12 frame = new T12.T12();
            frame.Show();
        }

        private void x09ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            X9.Form1 frame = new X9.Form1();
            frame.Show();
            
        }

        private void x10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            X10.Form1 frame = new X10.Form1();
            frame.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void v11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V11 frame = new V11();
            frame.Show();
        }

        private void x11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            X11 frame = new X11();
            frame.Show();
        }
    }
}
