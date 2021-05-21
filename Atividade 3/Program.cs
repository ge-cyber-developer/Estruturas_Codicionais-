using System;

namespace Ativ3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu salário?");
            double Salario = double.Parse(Console.ReadLine());

            if (Salario <= 900)
            {
                double SalarioAtual = Salario+Salario*0.3;
                Console.WriteLine("Parabéns! seu salário atual agora é de R$"+ SalarioAtual);

            }
            else 
            {
                Console.WriteLine("Seu salário atual agora é de R$"+ Salario);
                Console.WriteLine("Você não possui nenhum reajuste em seu salário");
            }
        }
    }
}
