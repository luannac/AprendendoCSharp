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
    public partial class T13 : Form
    {
        private int[,] matriz = new int[5, 5];
        private int iXMatriz = 0, iYMatriz = 0;
        public T13()
        {
            InitializeComponent();
            preencheTabela();
        }
        private void preencheTabela()
        {
            dgTable.Rows.Clear();
            dgTable.Rows.Add(matriz[0, 0], matriz[0, 1], matriz[0, 2], matriz[0, 3], matriz[0, 4]);
            dgTable.Rows.Add(matriz[1, 0], matriz[1, 1], matriz[1, 2], matriz[1, 3], matriz[1, 4]);
            dgTable.Rows.Add(matriz[2, 0], matriz[2, 1], matriz[2, 2], matriz[2, 3], matriz[2, 4]);
            dgTable.Rows.Add(matriz[3, 0], matriz[3, 1], matriz[3, 2], matriz[3, 3], matriz[3, 4]);
            dgTable.Rows.Add(matriz[4, 0], matriz[4, 1], matriz[4, 2], matriz[4, 3], matriz[4, 4]);
        }

        private void bRelatorio_Click(object sender, EventArgs e)
        {
            ArrayList lista = new ArrayList();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    lista.Add(matriz[i, j]);
                }
            }
            lista.Sort();
            int x = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = (int)lista[x];
                    x++;
                }
            }
            preencheTabela();
        }

        private void bAdicionar_Click(object sender, EventArgs e)
        {
            if (iXMatriz >= 0 && iYMatriz >= 0 && iXMatriz < 5 && iYMatriz < 5)
            {
                matriz[iXMatriz, iYMatriz] = Convert.ToInt32(txValor.Text);

                preencheTabela();
                if (iYMatriz == 4)
                {
                    iXMatriz++;
                    iYMatriz = 0;
                }
                else
                {
                    iYMatriz++;
                }
            }
            txValor.Text = " ";
        }
    }
}
