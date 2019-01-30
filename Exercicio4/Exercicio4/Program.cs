using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static double[] num = new double[2];
        static double resultado = 0;
        static char operacao;
        static void Main(string[] args)
        {
            

            Console.WriteLine("Entre com a operação-->");
            Console.WriteLine("+  Adição------------->");
            Console.WriteLine("-  Subtração---------->");
            Console.WriteLine("*  Multiplicação------>");
            Console.WriteLine("/  Divisão------------>");
            Console.WriteLine("---------------------->");
            Console.WriteLine();

            Console.Write("Digite a operação:");
            char.TryParse(Console.ReadLine(), out operacao);
            Console.Write("Informe o Primeiro valor:");
            double.TryParse(Console.ReadLine(), out num[0]);

            Console.Write("Informe o Segundo valor:");
            double.TryParse(Console.ReadLine(), out num[1]);

            switch (operacao)
            {
                case '+':
                    soma();
                    break;
                case '-':
                    subtracao();
                    break;
                case '*':
                    resultado = multiplicacao();
                    break;
                case '/':
                    resultado = divisao();
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(string.Format("\nO resultado é : {0}", resultado));
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Gray;

        }
        public static void soma()
        {
            resultado = num[0] + num[1];
        }
        public static void subtracao()
        {
            resultado = num[0] - num[1];
        }
        public static double multiplicacao()
        {
            return (num[0] * num[1]);
        }
        public static double divisao()
        {
            return  (num[0] / num[1]);
        }
    }
}
