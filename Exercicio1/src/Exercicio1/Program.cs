using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Program
    {
        public void Main(string[] args)
        {
            int _numero1, _numero2, _numero3;
            int _maiorNumero = 0;

            Console.WriteLine("Informe um número (1):");
            int.TryParse(Console.ReadLine(), out _numero1);

            Console.WriteLine("Informe um número (2):");
            int.TryParse(Console.ReadLine(), out _numero2);

            Console.WriteLine("Informe um número (3):");
            int.TryParse(Console.ReadLine(), out _numero3);

            if (_maiorNumero < _numero1)
                _maiorNumero = _numero1;

            if (_maiorNumero < _numero2)
                _maiorNumero = _numero2;

            if (_maiorNumero < _numero3)
                _maiorNumero = _numero3;

            Console.WriteLine(string.Format("O maior é : {0}", _maiorNumero));

            Console.ReadKey();
        }
    }
}
