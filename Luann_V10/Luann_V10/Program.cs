using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luann_V10
{
    /*V.10
    – Usando a estrutura de dados denominada Matriz, faça um programa que leia valores inteiros
        e positivos para uma matriz de ordem quatro. O programa deverá calcular e presentar na tela do usuário,
        a somatória, a média aritmética dos valores acima da Diagonal Principal da matriz.  
        Obs: O programa não deverá aceitar valores de “entrada” negativos ou iguais a 0 (zero),
        portanto, o programa deverá testar todos os valores de “entrada”.  */
    class Program
    {
        private static int somador;
        private static int quant = 4;
        private static int[,] matriz = new int[quant, quant];
        static void Main(string[] args)
        {
            Console.WriteLine("Matriz de valores!\n___________________________________");
            int i = 0;
            int j = 0;
            while (i < quant)
            {
                while (j < quant)
                {
                    recebe(i, j);
                    j++;
                }
                i++;
                j = 0;
            }

            i = 0;
            j = 0;
            while (i < quant)
            {
                while (j < quant)
                {
                    Console.Write("[{0}]", matriz[i, j]);
                    j++;
                }
                Console.WriteLine();
                i++;
                j = 0;
            }
            mostra();


            Console.ReadKey();
        }
        private static void recebe(int l, int c)
        {
            do
            {
                Console.WriteLine(string.Format("Digite o valor da coluna {0} do linha {1}", c + 1, l + 1));
                matriz[l, c] = Convert.ToInt32(Console.ReadLine());
                somador += matriz[l, c];
            } while (matriz[l, c] <= 0);
        }
        private static void mostra()
        {
            ArrayList lista = new ArrayList();
            int maior = matriz[0, 0], menor = matriz[0, 0], xmaior = 0, ymaior = 0, xmenor = 0, ymenor = 0;
            int soma = 0, i = 0, j = 0;
            while (i < quant)
            {
                while (j < quant)
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
            Console.WriteLine();
            int media = soma / (quant * quant);
            Console.WriteLine(string.Format("A média é: {0}\nA soma é: {1}\nO maior é: {2} e esta no x:{3} y:{4}\nO menor é:{5} e está no x:{6} y:{7}\n", media, soma, maior, xmaior, ymaior, menor, xmenor, ymenor));
            Console.WriteLine();
            i = 0;
            while (i < lista.Count)
            {
                Console.Write("[{0}]", lista[i]);
                i++;
            }
            Console.WriteLine("\n\n");
        }
    }
}
