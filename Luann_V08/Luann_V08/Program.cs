using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luann_V08
{
    /*V.8 
    – Usando a estrutura de dados denominada Matriz, faça um programa que leia valores inteiros
        e positivos para uma matriz com sete linhas e três colunas. O programa deverá apresentar na 
        tela do usuário a matriz inversa.  
        Obs: O programa não deverá aceitar valores de “entrada” negativos ou iguais a 0 (zero),
        portanto, o programa deverá testar todos os valores de “entrada”.*/
    class Program
    {
        private static int quantx = 7, quanty = 3;
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
                    Console.Write("[{0}]",matriz[i, j]);
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
            int i = 0, j = 0;
            while (i < quanty)
            {
                while (j < quantx)
                {
                    Console.Write("[{0}]",matrizContra[i, j]);
                    j++;
                }
                Console.WriteLine();
                i++;
                j = 0;
            }
        }
    }
}
