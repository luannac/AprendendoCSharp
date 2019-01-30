using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5._1
{
    class Program
    {

        static void Main(string[] args)
        {
            Program p = new Program();
            string frase;
            char a, b;

            Console.WriteLine("Digite uma frase:");
            frase = Console.ReadLine();

            Console.WriteLine("Digite o caracter a ser substituido:");
            char.TryParse(Console.ReadLine(), out a);

            Console.WriteLine("Digite qual caracter colocar :");
            char.TryParse(Console.ReadLine(), out b);

            Console.WriteLine(p.alterar(frase,a,b));
            Console.ReadKey();
        }
        private string alterar(string frase,char a,char b)
        {
            if (frase.Trim().Length > 0)
            {
                int total = frase.Length;
                int count = 0;

                var stringBuilder = new StringBuilder(frase);

                while (count < total)
                {
                    if (stringBuilder[count] == a)
                    {
                        stringBuilder[count] = b;
                    }
                    count++;
                }
                frase = stringBuilder.ToString();
                return frase;
            }
            else
            {
                return null;
            }
        }
    }
}
