using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioE3
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp;
            string[,] tabela = new string[4,3];
            tabela[0, 0] = "1";
            tabela[0, 1] = "Carlos Alberto Silva";
            tabela[0, 2] = "30";
            tabela[1, 0] = "2";
            tabela[1, 1] = "Maria Antonieta Pereira";
            tabela[1, 2] = "24";
            tabela[2, 0] = "3";
            tabela[2, 1] = "Júlio César Campos";
            tabela[2, 2] = "28";
            tabela[3, 0] = "4";
            tabela[3, 1] = "Fernanda Paula Santos";
            tabela[3, 2] = "26";


            Console.WriteLine("Digite o numero do Funcionário:");
            resp = Convert.ToString(Console.ReadLine());
            try
            {
                int id = Convert.ToInt32(resp)-1;
                Console.WriteLine(string.Format("\n\nFuncionário: {0}\nNome: {1}\nIdade: {2}", tabela[id, 0],tabela[id,1],tabela[id,2]));
            }catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }
    }
}
