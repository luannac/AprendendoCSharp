using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            string frase = "Agora eu sou um bom desenvolverdor.";
            Console.WriteLine(p.alterar(frase));
            Console.ReadKey();
        }
        private string alterar(string frase)
        {
            if (frase.Trim().Length > 0)
            {
                int total = frase.Length;
                int count = 0;

                var stringBuilder = new StringBuilder(frase);

                while (count < total) { 
                    if(stringBuilder[count]== 'o')
                    {
                        stringBuilder[count] = '&';
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
