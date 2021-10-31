using System;

namespace Soma
{
    public class Somar
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Insira o primeiro valor: ");
            int val1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor: ");
            int val2 = int.Parse(Console.ReadLine());

            int soma = val1 + val2;

            Console.WriteLine($"Somando {val1} com {val2} o resultado é: {soma}");

        }
    }
}
