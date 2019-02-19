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
    public partial class T11 : Form
    {
        private int[,] matriz = new int[5, 5];
        private int iXMatriz=0, iYMatriz=0;
        public T11()
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
        }

        private void bRelatorio_Click(object sender, EventArgs e)
        {
            if(iXMatriz==5 && iYMatriz == 0)
            {
                mostra();
            }
        }

        private void mostra()
        {
            ArrayList lista = new ArrayList();
            int maior = matriz[0, 0], menor = matriz[0, 0], xmaior = 0, ymaior = 0, xmenor = 0, ymenor = 0;
            int soma = 0, i = 0, j = 0;
            while (i < 5)
            {
                while (j < 5)
                {
                    soma += matriz[i, j];
                    if (matriz[i, j] > maior)
                    {
                        maior = matriz[i, j];
                        ymaior = i + 1;
                        xmaior = j + 1;
                    }
                    if (matriz[i, j] < menor)
                    {
                        menor = matriz[i, j];
                        ymenor = i + 1;
                        xmenor = j + 1;
                    }
                    if (i < j)
                    {
                        lista.Add((int)matriz[i, j]);
                    }
                    j++;
                }
                i++;
                j = 0;
            }

            int media = soma / (5 * 5);
            tResposta.Text = string.Format("A média é: {0}\nA soma é: {1}\nO maior é: {2} e esta no x:{3} y:{4}\nO menor é:{5} e está no x:{6} y:{7}\n", media, soma, maior, xmaior, ymaior, menor, xmenor, ymenor);
            
        }
    }
}
