using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioE2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite o Código da Matéria:");
            numero = Convert.ToInt32(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Matéria Matematica");
                    break;
                case 2:
                    Console.WriteLine("Matéria Informática");
                    break;
                case 3:
                    Console.WriteLine("Matéria História");
                    break;
                case 4:
                    Console.WriteLine("Matéria Portugues");
                    break;
                case 5:
                    Console.WriteLine("Matéria Geografia");
                    break;
                case 6:
                    Console.WriteLine("Matéria Ingles");
                    break;
                case 7:
                    Console.WriteLine("Matéria Quimica");
                    break;
                case 8:
                    Console.WriteLine("Matéria Fisica");
                    break;
            }
            Console.ReadKey();
        }
    }
}
