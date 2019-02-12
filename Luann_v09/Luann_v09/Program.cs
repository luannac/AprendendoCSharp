using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luann_v09
{
    /*V.9 
    – Usando a estrutura de dados denominada Matriz, faça um programa que leia valores inteiros
        e positivos para uma matriz de ordem seis. O programa deverá calcular e presentar na tela do usuário,
        a somatória, a média aritmética e os valores lidos na Diagonal Principal da matriz.  
        Obs: O programa não deverá aceitar valores de “entrada” negativos ou iguais a 0 (zero),
        portanto, o programa deverá testar todos os valores de “entrada”.   */
    class Program
    {
        private static int[,] matriz;
        static void Main(string[] args)
        {
            matriz = new int[6, 6];

            Console.WriteLine("Matriz de valores!\n___________________________________");

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
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
            int contador = 5;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (j == contador)
                    {
                        valoresDiag.Add(matriz[i, j]);
                        somador += matriz[i, j];
                    }
                    Console.Write("[{0}] ", matriz[i, j]);
                }
                Console.WriteLine();
                contador--;
            }
            Console.WriteLine("\n\nOs valores são: ");
            foreach (int valor in valoresDiag)
            {
                Console.Write("{0},", valor);
            }
            Console.WriteLine();
            Console.WriteLine("Soma: {0} ,  Média: {1};", somador, somador / valoresDiag.Count);

        }
    }
}
