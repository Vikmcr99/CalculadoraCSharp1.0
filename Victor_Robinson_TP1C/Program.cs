using System;
using System.Collections.Generic;
using System.Text;

// Aqui foi minha tentativa de fazer orientado a objeto, mas acabei fazendo de acordo com o enunciado do TP


namespace Victor_Robinson_TP1C
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.WriteLine("Escolha uma operação abaixo:");
            Console.WriteLine("1 - Somar\n2 - Subtrair\n3 - Multiplicar\n4 - Dividir\n5 - Sair");

            string escolha = Console.ReadLine();

            // Optei pelo If ao inves do Switch

            //if (escolha == "1")
            //{
            //    Soma();
            //}
            //if (escolha == "2")
            //{
            //    Subtracao();
            //}
            //if (escolha == "3")
            //{
            //    Multiplicar();
            //}
            //if (escolha == "4")
            //{
            //    Dividir();
            //}
            //if (escolha == "5")
            //{
            //    Console.WriteLine("Saindo...");
            //    Environment.Exit(0);
            //}
        }

    }
}
