using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luann_T04
{
    class Program
    {
        private static int[,] numeros = new int[3, 3];
        static void Main(string[] args)
        {
            Console.WriteLine("Média de Matriz de valores!\n___________________________________");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    recebe(j, i);
                }
            }

            mostraMedia();
            Console.ReadKey();
        }
        private static void recebe(int n, int v)
        {
            do
            {
                Console.WriteLine(string.Format("Digite o {0} numero do Vetor {1}", n + 1, v + 1));
                numeros[0, n] = Convert.ToInt32(Console.ReadLine());
                numeros[1, n] = numeros[0, n];
            } while (numeros[0, n] <= 0);
        }
        private static void mostraMedia()
        {
            int resp = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    resp += numeros[i, j];
                }
            }
            resp = resp / 9;
            Console.WriteLine(string.Format("A média é: {0}\n", resp));
            Console.WriteLine("\n\n");
        }
    }
}
