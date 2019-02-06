using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luann_R08
{
    class Program
    {
        private static int[,] numeros = new int[3,15];
        static void Main(string[] args)
        {
            Console.WriteLine("Soma de Vetores de valores!\n___________________________________");
            for (int i = 0; i < 15; i++)
            {
                recebe(i);
            }

            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine(string.Format("Vetor {0}\n", i + 1));
                for(int j = 0; j < 15; j++)
                {
                    Console.WriteLine(string.Format("[{0}]", numeros[i, j]));
                }
                Console.WriteLine("\n\n");
            }

            mostraSoma();
            Console.ReadKey();
        }
        private static void recebe(int n)
        {
            do
            {
                Console.WriteLine(string.Format("Digite o {0} numero", n + 1));
                numeros[0,n] = Convert.ToInt32(Console.ReadLine());
                numeros[1, n] = numeros[0, n];
            } while (numeros[0,n] <= 0);
        }
        private static void mostraSoma()
        {

            for (int i = 0; i < 15; i++)
            {
                numeros[2, i] = numeros[0, i] + numeros[1, i];
            }
            Console.WriteLine("O resultado é: \n");
            for (int j = 0; j < 15; j++)
            {
                Console.WriteLine(string.Format("[{0}]", numeros[2, j]));
            }
            Console.WriteLine("\n\n");
        }
    }
}
