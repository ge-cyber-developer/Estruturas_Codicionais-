using System;

namespace Ativ2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Em que ano você nasceu?");
            int AnoNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Em que ano estamos?");
            int AnoAtual = int.Parse(Console.ReadLine());
            

            int Idade = AnoAtual - AnoNascimento ;
            int IdadeSemanas = Idade*12;

            Console.WriteLine("Você tem " + Idade + " anos de idade");
            Console.WriteLine("E você tem " + IdadeSemanas + " semanas de idade ");
        }
    }
}
