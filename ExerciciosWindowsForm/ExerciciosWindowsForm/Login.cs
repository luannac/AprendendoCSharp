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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            if (tbUsu.Text == "Senai" && txSenha.Text =="Senai1234")
            {
                Principal principal = new Principal();
                principal.Text = " Ola Mundo";
                principal.Show();
                this.Hide();
            }
        }
    }
}
