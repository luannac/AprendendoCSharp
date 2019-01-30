using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario;
            char resp;

            do
            {
                Console.WriteLine("Reajuste Salarial");
                Console.Write("Salário: ");
                float.TryParse(Console.ReadLine(), out salario);
                if (salario < 1700)
                {
                    salario += 300;
                    Console.WriteLine(string.Format("Rejuste de R$300.00, salário atualizado: {0}", salario));
                }
                else
                {
                    salario += 200;
                    Console.WriteLine(string.Format("Rejuste de R$200.00, salário atualizado: {0}", salario));
                }
                Console.WriteLine("Deseja fazer de novo:");
                char.TryParse(Console.ReadLine(), out resp);
                Console.Clear();
            } while (resp.Equals('s'));     
        }
    }
}
