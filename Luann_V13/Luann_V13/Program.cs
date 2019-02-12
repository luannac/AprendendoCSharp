using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luann_V13
{
    /*V.13 
    – Usando a estrutura de dados denominada Matriz, faça um programa que leia valores inteiros
        e positivos para uma matriz com três linhas e cinco colunas. O programa deverá colocar os valores
        lidos na matriz em ordem crescente e apresentar na tela do usuário a matriz com os valores originais
        e a matriz com os valores ordenados.  
        Obs: O programa não deverá aceitar valores de “entrada” negativos ou iguais a 0 (zero), portanto,
        o programa deverá testar todos os valores de “entrada”. */
    class Program
    {
        private static int[,] matriz, matrizCre;
        private static int i, j;

        static void Main(string[] args)
        {
            matriz = new int[3, 5];
            matrizCre = new int[3, 5];

            Console.WriteLine("Matriz de valores!\n___________________________________");
            i = 0;
            j = 0;
            while ( i < 3)
            {
                while ( j < 5)
                {
                    recebe(i, j);
                    j++;
                }
                i++;
                j = 0;
            }
            ordenar();
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
        private static void ordenar()
        {
            ArrayList lista = new ArrayList();
            i = 0;
            j = 0;
            while (i < 3)
            {
                while (j < 5)
                {
                    lista.Add(matriz[i, j]);
                    j++;
                }
                i++;
                j = 0;
            }
            lista.Sort();
            int x = 0;

            i = 0;
            j = 0;
            while (i < 3)
            {
                while (j < 5)
                {
                    matrizCre[i, j] = (int)lista[x];
                    x++;
                    j++;
                }
                i++;
                j = 0;
            }
        }
        private static void mostra()
        {
            i = 0;
            j = 0;
            while (i < 3)
            {
                while (j < 5)
                {
                    Console.Write("[{0}] ", matriz[i, j]);
                    j++;
                }
                Console.WriteLine();
                i++;
                j = 0;
            }
            Console.WriteLine();

            i = 0;
            j = 0;
            while (i < 3)
            {
                while (j < 5)
                {
                    Console.Write("[{0}] ", matrizCre[i, j]);
                    j++;
                }
                Console.WriteLine();
                i++;
                j = 0;
            }
        }
    }
}
