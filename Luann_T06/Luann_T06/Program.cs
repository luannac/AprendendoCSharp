using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luann_T06
{
    /*T.6 
    – Usando a estrutura de dados denominada Matriz, faça um programa que leia valores inteiros e positivos para uma matriz com três linhas e oito colunas.
        O programa deverá transferir os valores lidos para uma matriz com oito linhas e três colunas. Apresentar as matrizes na tela do usuário.
        Obs: O programa não deverá aceitar valores de “entrada” negativos ou iguais a 0 (zero), portanto, o programa deverá testar todos os valores de “entrada”.*/
    class Program
    {
        private static int[,] matriz1,matriz2;
        static void Main(string[] args)
        {
            matriz1 = new int[3, 8];
            matriz2 = new int[8, 3];

            Console.WriteLine("Matriz de valores!\n___________________________________");

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    recebe(j, i);
                }
            }
            passagem();
            mostra();
            Console.ReadKey();
        }
        private static void recebe(int n, int v)
        {
            do
            {
                Console.WriteLine(string.Format("Digite o valor da coluna {0} do linha {1}", n + 1, v + 1));
                matriz1[n,v] = Convert.ToInt32(Console.ReadLine());
            } while (matriz1[n, v] <= 0);
        }
        private static void passagem()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz2[i, j] = matriz1[j, i];
                }
            }
        }
        private static void mostra()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(string.Format("[{0}] ", matriz1[j, i]));
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(string.Format("[{0}] ", matriz1[i,j]));
                }
                Console.WriteLine();
            }
        }
    }
}
