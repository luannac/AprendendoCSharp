using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioE6
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            double salario;
            EstadoCivil[] estados = new EstadoCivil[3];
            estados[0] = new EstadoCivil("Solteiro", 0.30);
            estados[1] = new EstadoCivil("Casados", 0.20);
            estados[2] = new EstadoCivil("Outro", 0.25);

            Console.WriteLine("Digite seu salário:");
            double.TryParse(Console.ReadLine(), out salario);
            Console.WriteLine("Digite o Estado civil(1-Solteiro\\2 - Casado\\ 3- Outros)");
            id = Convert.ToInt32(Console.ReadLine())-1;

            Console.WriteLine(string.Format("O desconto será de {0} reais.", salario * estados[id].aliquota));
            Console.ReadKey();

        }
    }
    class EstadoCivil
    {
        public double aliquota;
        public string estado;

        public EstadoCivil(string nome,double valor)
        {
            estado = nome;
            aliquota = valor;
        }
    }
}
