using System;

namespace Divisao
{
    public class Dividir
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Insira o primeiro valor: ");
            int val1 = int.Parse(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("Insira o segundo valor: ");
                int val2 = int.Parse(Console.ReadLine());
                if (val2 == 0)
                {
                    Console.WriteLine("ERRO!, nao é possivel dividir por ZERO!");
                }
                else
                {
                    int divisao = val1 / val2;
                    int resto = val1 % val2;
                    Console.WriteLine($"Dividindo {val1} com {val2} o resultado é {divisao}, e o resto é {resto}");
                    break;
                }
            }
        }
    }
}
