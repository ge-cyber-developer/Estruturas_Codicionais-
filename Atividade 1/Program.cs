using System;

namespace Ativ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());

            int meses = idade*12;
            int dias = idade*365;
            int horas = idade*24;
            int minutos = idade*60;

            Console.WriteLine("Você tem: " + meses +" meses, " + dias + " dias, "+ horas + " horas, e " + minutos + " minutos de idade");
        }
    }
}
