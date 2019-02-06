using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luann_R09
{
    class Program
    {
        private static int[,] numeros = new int[3, 20];
        static void Main(string[] args)
        {
            Console.WriteLine("Ordenação de Vetores de valores!\n___________________________________");
            for (int i = 0; i < 20; i++)
            {
                recebe(i);
            }

            ordenaCres(1);
            ordenaDesc(2);

            Console.WriteLine("Vetor 1\tVetor2\tVetor3\n");
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(string.Format("[{0}]\t", numeros[j,i]));
                }
                Console.WriteLine("\n");
            }

            
            Console.ReadKey();
        }
        private static void recebe(int n)
        {
            do
            {
                Console.WriteLine(string.Format("Digite o {0} numero", n + 1));
                numeros[0, n] = Convert.ToInt32(Console.ReadLine());
                numeros[1, n] = numeros[0, n];
                numeros[2, n] = numeros[0, n];
            } while (numeros[0, n] <= 0);
        }
        private static void ordenaCres(int idVetor)
        {
            int auxiliar = 0;
            for(int i = 1; i < 19; i++)
            {
                for (int j = i; j < 20; j++)
                {
                    if (numeros[idVetor, j - 1] > numeros[idVetor, j]) {
                        auxiliar = numeros[idVetor, j - 1];
                        numeros[idVetor, j - 1] = numeros[idVetor, j];
                        numeros[idVetor, j] = auxiliar;
                    }
                }
            }
        }
        private static void ordenaDesc(int idVetor)
        {
            int auxiliar = 0;
            for (int i = 1; i < 19; i++)
            {
                for (int j = i; j < 20; j++)
                {
                    if (numeros[idVetor, j - 1] < numeros[idVetor, j])
                    {
                        auxiliar = numeros[idVetor, j - 1];
                        numeros[idVetor, j - 1] = numeros[idVetor, j];
                        numeros[idVetor, j] = auxiliar;
                    }
                }
            }
        }
    }
}
