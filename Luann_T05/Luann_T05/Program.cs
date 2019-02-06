using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luann_T05
{
    class Program
    {
        private static int[,] numeros = new int[10, 10];
        static void Main(string[] args)
        {
            Console.WriteLine("Matriz de valores!\n___________________________________");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    recebe(j, i);
                }
            }

            mostra();
            Console.ReadKey();
        }
        private static void recebe(int n, int v)
        {
            do
            {
                Console.WriteLine(string.Format("Digite o {0} numero do Vetor {1}", n + 1, v + 1));
                numeros[v, n] = Convert.ToInt32(Console.ReadLine());
            } while (numeros[0, n] <= 0);
        }
        private static void mostra()
        {
            int maior = numeros[0, 0], menor=numeros[0,0], xmaior=0, ymaior=0, xmenor=0, ymenor=0;
            int soma = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    soma += numeros[i, j];
                    if (numeros[i, j] > maior)
                    {
                        maior = numeros[i, j];
                        ymaior = i + 1;
                        xmaior = j + 1;
                    }
                    if (numeros[i, j] < menor)
                    {
                        menor = numeros[i, j];
                        ymenor = i + 1;
                        xmenor = j + 1;
                    }
                }
            }
            int media = soma / 100;
            Console.WriteLine(string.Format("A média é: {0}\nA soma é: {1}\nO maior é: {2} e esta no x:{3} y:{4}\nO menor é:{5} e está no x:{6} y:{7}\n", media,soma,maior,xmaior,ymaior,menor,xmenor,ymenor));
            Console.WriteLine("\n\n");
        }
    }
}
