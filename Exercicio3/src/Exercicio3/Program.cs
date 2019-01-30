using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio3
{
    public class Program
    {
        public void Main(string[] args)
        {
            char _caracter;
            bool _eletra = false;

            Console.Write("Informe um caracter: ");
            char.TryParse(Console.ReadLine(), out _caracter);
            Console.WriteLine("Identificando...../n");

            Console.WriteLine(string.Format("\nCaracter Informado: {0}", _caracter.ToString()));
            
            if (Convert.ToInt32(_caracter) > 47 && Convert.ToInt32(_caracter) < 58)
                _eletra = true;

            Console.ForegroundColor = ConsoleColor.Blue;

            if (_eletra) { 
                Console.WriteLine("É numero!");
            }
            else { 
                Console.WriteLine("É letra!");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();
        }
    }
}
