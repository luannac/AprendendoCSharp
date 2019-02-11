using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luann_T13
    /*T.13 
    –Usando aestrutura de dados denominada Matriz, faça um programa que leia valores inteiros e positivos para uma matriz com três linhas e cinco colunas.
        O programa deverá colocar os valores lidos na matriz em ordem crescente e apresentar na tela do usuário a matriz com 
        os valores originais e a matriz com os valores ordenados.
        Obs:O programa não deverá aceitar valores de “entrada”negativos ou iguais a 0(zero), portanto, o programa deverá testartodos os valores de “entrada”. */
{
    class Program
    {
        private static int[,] matriz,matrizCre;
        private static ArrayList lista = new ArrayList();

        static void Main(string[] args)
        {
            matriz = new int[3, 5];
            matrizCre = new int[3, 5];

            Console.WriteLine("Matriz de valores!\n___________________________________");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
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
        private static void ordenar()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    lista.Add(matriz[i, j]);
                }
            }
            lista.Sort();


            
        }
        private static void mostra()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("[{0}] ", matriz[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
