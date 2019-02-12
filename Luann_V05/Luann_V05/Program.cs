using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luann_V05
{
    /*V.5
    – Usando a estrutura de dados denominada Matriz, faça um programa que leia valores inteiros e
        positivos para uma matriz de ordem dez e retorne a somatória dos números lidos, a média aritmética
        dos números lidos, o maior e o menor número lido e as suas respectivas posições (linha x coluna) na Matriz.  
        Obs: O programa não deverá aceitar valores de “entrada” negativos ou iguais a 0 (zero), portanto,
        o programa deverá testar todos os valores de “entrada”.   */
    class Program
    {
        private static int somador;
        private static int quant=10;
        private static int[,] matriz = new int[quant, quant];
        static void Main(string[] args)
        {
            Console.WriteLine("Matriz de valores!\n___________________________________");
            int i = 0;
            int j = 0;
            while (i< quant)
            {
                while( j < quant)
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
                    Console.Write(matriz[i, j]);
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
            int maior = matriz[0, 0], menor = matriz[0, 0], xmaior = 0, ymaior = 0, xmenor = 0, ymenor = 0;
            int soma = 0, i = 0, j = 0 ;
            while (i < quant)
            {
                while ( j < quant)
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
                    j++;
                }
                i++;
            }
            int media = soma / (quant* quant);
            Console.WriteLine(string.Format("A média é: {0}\nA soma é: {1}\nO maior é: {2} e esta no x:{3} y:{4}\nO menor é:{5} e está no x:{6} y:{7}\n", media, soma, maior, xmaior, ymaior, menor, xmenor, ymenor));
            Console.WriteLine("\n\n");
        }
    }
}
