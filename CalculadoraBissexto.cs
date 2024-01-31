using System;

namespace CalculadoraBissexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu ano de nascimento.");
            int birthday = int.Parse(Console.ReadLine());

            if(birthday%4 == 0 && birthday%100 != 0 )
            {
                Console.WriteLine("Você nasceu em um ano bissexto.");
            } else
            {
                Console.WriteLine("Voce não nasceu em um ano bissexto.");
            }
        }
    }
}
