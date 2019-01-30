using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioE4
{
    class Program
    {
        static void Main(string[] args)
        {
            int idUniversidade, idCurso;
            string[] univeridade= new string[3], curso= new string[3];
            univeridade[0] = "Usp";
            univeridade[1] = "Unicamp";
            univeridade[2] = "PUCC";
            curso[0] = "Medicina";
            curso[1] = "Engenharia";
            curso[2] = "Licenciatura";

            Console.WriteLine("Digite o codigo da Universidade:");
            idUniversidade = Convert.ToInt32(Console.ReadLine())-1;

            Console.WriteLine("Digite o codigo do Curso:");
            idCurso = Convert.ToInt32(Console.ReadLine())-1;

            Console.WriteLine("Você escolheu \na universidade: {0}\ncurso: {1}",univeridade[idUniversidade],curso[idCurso]);
            Console.ReadKey();

        }
    }
}
