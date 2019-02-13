using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciosWindowsForm
{
    public partial class F01 : Form
    {
        ArrayList arrLista = new ArrayList();
        public F01()
        {
            InitializeComponent();
            
            arrLista.Add(new Produto(1, "Lápis"));
            arrLista.Add(new Produto(2, "Caneta"));
            arrLista.Add(new Produto(3, "Borracha"));
            arrLista.Add(new Produto(4, "Caderno"));
            arrLista.Add(new Produto(5, "Régua"));

            foreach(Produto produto in arrLista)
            {
                grtaProdutos.Rows.Add(produto.iId, produto.sName);
            }

        }

        private void bProduto_Click(object sender, EventArgs e)
        {
            int comparador = Convert.ToInt32(txtProduto.Text);
            foreach(Produto prod in arrLista)
            {
                if(prod.iId == comparador)
                {
                    lIdResultado.Text = prod.iId.ToString();
                    lProdutoResultado.Text = prod.sName;
                }
            }
        }
    }
    public class Produto
    {
        public int iId;
        public String sName;

        public Produto(int newId,String newName)
        {
            iId = newId;
            sName = newName;
        }
    }
}
