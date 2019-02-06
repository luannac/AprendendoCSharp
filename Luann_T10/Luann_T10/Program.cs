using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luann_T10
{
    /*T.10 
    – Usando a estrutura de dados denominada Matriz, faça um programa que leia valores inteiros e
        positivos para uma matriz de ordem quatro. O programa deverá calcular e presentar na tela do usuário,
        a somatória, a média aritmética dos valores acima da Diagonal Principal da matriz.
        Obs: O programa não deverá aceitar valores de “entrada” negativos ou iguais a 0 (zero),
        portanto, o programa deverá testar todos os valores de “entrada”.*/
    class Program
    {
        private static int[,] matriz;
        static void Main(string[] args)
        {
            matriz = new int[4, 4];

            Console.WriteLine("Matriz de valores!\n___________________________________");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
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
            ArrayList valoresDiag = new ArrayList();
            int somador = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i < j)
                    {
                        valoresDiag.Add(matriz[i, j]);
                        somador += matriz[i, i];
                    }
                    Console.Write("[{0}] ", matriz[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\nOs valores são: ");
            foreach (int valor in valoresDiag)
            {
                Console.Write("{0},", valor);
            }
            Console.WriteLine();
            Console.WriteLine("Soma: {0} ,  Média: {1};", somador, somador / 6);

        }
    }
}
