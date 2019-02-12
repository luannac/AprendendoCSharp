using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luann_V07
{
    /*V.7 
    – Usando a estrutura de dados denominada Matriz, faça um programa que leia valores inteiros e positivos
        para uma matriz com cinco linhas e quatro colunas. O programa deverá calcular a maior diferença entre os
        números lidos e apresentar, na tela do usuário, o valor da diferença, os 
        números que geraram esta diferença e as suas respectivas coordenadas (linha x coluna) na Matriz.  
        Obs: O programa não deverá aceitar valores de “entrada” negativos ou iguais a 0 (zero), portanto, 
        o programa deverá testar todos os valores de “entrada”. */
    class Program
    {
        private static int quantx = 5, quanty = 4;
        private static int[,] matriz = new int[quantx, quanty];
        private static int[,] matrizContra = new int[quanty, quantx];
        static void Main(string[] args)
        {
            Console.WriteLine("Matriz de valores!\n___________________________________");
            int i = 0;
            int j = 0;
            while (i < quantx)
            {
                while (j < quanty)
                {
                    recebe(i, j);
                    j++;
                }
                i++;
                j = 0;
            }

            i = 0;
            j = 0;
            while (i < quantx)
            {
                while (j < quanty)
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
            } while (matriz[l, c] <= 0);
        }
        private static void mostra()
        {
            int maior = matriz[0, 0], menor = matriz[0, 0], xmaior = 0, ymaior = 0, xmenor = 0, ymenor = 0;
            int i = 0, j = 0;
            while (i < quantx)
            {
                while (j < quanty)
                {
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
                j = 0;
            
            }
            Console.WriteLine(string.Format("O maior é: {0} e esta no x:{1} y:{2}\nO menor é:{3} e está no x:{4} y:{5}\nA diferença de valores: {6}", maior, xmaior, ymaior, menor, xmenor, ymenor,maior-menor));
        }
    }
}
