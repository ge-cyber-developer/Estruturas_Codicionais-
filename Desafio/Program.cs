using System;

namespace Ativ4_Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade <= 7 && idade >= 5)
            {
                Console.WriteLine("Parabéns! sua categoria é Intantil A");
            }
            else if (idade <= 10 && idade >= 8)
            {
                Console.WriteLine("Parabéns! sua categoria é Intantil B");
            }
            else if (idade <= 13 && idade >= 11)
            {
                Console.WriteLine("Parabéns! sua categoria é Juvenil A");
            }
            else if (idade <= 17 && idade >= 14)
            {
                Console.WriteLine("Parabéns! sua categoria é Juvenil B");
            }
            else if (idade >= 18)
            {
                Console.WriteLine("Parabéns! sua categoria é Sênior");
            }
            else  
            {
                Console.WriteLine("Resposta inválida! por favor digite novamente.");
            }
        }
    }
}
