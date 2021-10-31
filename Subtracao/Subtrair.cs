using System;

namespace Subtracao
{
    class Subtrair
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Insira o primeiro valor: ");
            int val1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor: ");
            int val2 = int.Parse(Console.ReadLine());

            int subtracao = val1 - val2;

            Console.WriteLine($"Subtraindo {val1} com {val2} o resultado é: {subtracao}");

        }
    }
}
