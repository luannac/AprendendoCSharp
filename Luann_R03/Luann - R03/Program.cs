using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luann___R03
{
    class Program
    {
        private static int[] numeros = new int[10];
        static void Main(string[] args)
        {
            Console.WriteLine("Soma de 10 valores!\n________________________");
            for (int i = 0; i < 10; i++)
            {
                recebe(i);
            }
            mostraSoma();
            Console.ReadKey();
        }
        private static void recebe(int n)
        {
            do
            {
                Console.WriteLine(string.Format("Digite o {0} numero", n + 1));
                numeros[n] = Convert.ToInt32(Console.ReadLine());
            } while (numeros[n] <= 0);
        }
        private static void mostraSoma()
        {
            int resp=0;
            for(int i = 0; i < 10; i++)
            {
                resp += numeros[i];
            }
            Console.WriteLine(string.Format("O resultado é: {0}", resp));
        }
    }
}
