using System;

namespace Exer_Estrutura_condicional1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Negativo");
            }
            else
            {
                Console.WriteLine("Não Negativo");
            }

            Console.WriteLine("Bom dia");
        }
    }
}
