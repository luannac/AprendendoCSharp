using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luann_T07
{
    /*T.7 
    – Usando a estrutura de dados denominada Matriz, faça um programa que leia valores inteiros e positivos para uma matriz com cinco linhas e quatro colunas.
        O programa deverá calcular a maior diferença entre os números lidos e apresentar, na tela do usuário, o valor da diferença, os números que geraram esta diferença 
        e as suas respectivas coordenadas (linha x coluna) na Matriz.
        Obs: O programa não deverá aceitar valores de “entrada” negativos ou iguais a 0 (zero), portanto, o programa deverá testar todos os valores de “entrada”.*/
    class Program
    {
        private static int[,] matriz = new int[5, 4];
        static void Main(string[] args)
        {

            Console.WriteLine("Matriz de valores!\n___________________________________");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    recebe(i,j);
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
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(string.Format("[{0}] ", matriz[j,i]));
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");

            int maior = matriz[0,0], menor = matriz[0, 0], xmaior = 0, ymaior = 0, xmenor = 0, ymenor = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matriz[i, j] > maior)
                    {
                        maior = matriz[i, j];
                        ymaior = i + 1;
                        xmaior = j + 1;
                    }
                    if (matriz[i, j] < menor)
                    {
                        menor = matriz[i, j];
                        ymenor = i + 1;
                        xmenor = j + 1;
                    }
                }
            }
            Console.WriteLine(string.Format("A maior diferença é de {0}, \nsendo o primeiro {1} estando em x:{2} e y:{3}\no segundo {4} estando em x:{5} e y:{6}",maior-menor,menor,xmenor,ymenor,maior,xmaior,ymaior));
        }
    }
}
