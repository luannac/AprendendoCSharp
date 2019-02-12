using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luann_V04
{
       /* V.4 
          – Usando a estrutura de dados denominada Matriz, faça um programa que leia valores inteiros e positivos para uma matriz de ordem três e
             retorne a média aritmética dos números lidos na Matriz.
             Obs: O programa não deverá aceitar valores de “entrada” negativos ou iguais a 0 (zero), portanto, o programa deverá testar todos os valores de “entrada”.*/
    class Program
    {
        private static int[,] matriz = new int[3, 3];
        private static int somador;
        static void Main(string[] args)
        {
            Console.WriteLine("Matriz de valores!\n___________________________________");
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    recebe(i, j);                }
            }

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("A média é: {0}", (somador / 9));


            Console.ReadKey();
        }
        private static void recebe(int l, int c)
        {
            do
            {
                Console.WriteLine(string.Format("Digite o valor da coluna {0} do linha {1}", c + 1, l + 1));
                matriz[l, c] = Convert.ToInt32(Console.ReadLine());
                somador += matriz[l, c];
            } while (matriz[l, c] <= 0);
        }
    }
}
