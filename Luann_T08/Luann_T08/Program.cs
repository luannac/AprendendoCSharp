using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luann_T08
{
    /*
    T.8
    – Usando a estrutura de dados denominada Matriz, faça um programa que leia valores inteiros e positivos para 
    uma matriz com sete linhas e três colunas. O programa deverá apresentar na tela do usuário a matriz inversa.
    Obs: O programa não deverá aceitar valores de “entrada” negativos ou iguais a 0 (zero), portanto, o programa 
    deverá testar todos os valores de “entrada”.*/
    class Program
    {
        private static int[,] matriz;
        static void Main(string[] args)
        {
            matriz = new int[7, 3];

            Console.WriteLine("Matriz de valores!\n___________________________________");

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    recebe(i, j);
                }
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
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j <3; j++)
                {
                    Console.Write("[{0}]", matriz[i,j]);
                }
                Console.WriteLine();
            }
            Console.Write("\n\n");
            for (int i = 6; i >=0; i--)
            {
                for(int j = 2; j >=0 ; j--)
                {
                    Console.Write("[{0}]", matriz[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
