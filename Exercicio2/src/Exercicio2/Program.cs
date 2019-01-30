using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Program
    {
        public void Main(string[] args)
        {
            int numeroDigitado;

            Console.Write("Insira um número : ");

            numeroDigitado = Convert.ToInt32(Console.ReadLine());

            if (numeroDigitado % 2 == 0)
                Console.WriteLine("PAR");
            else
                Console.WriteLine("IMPAR");

            Console.ReadKey();
        }
    }
}
