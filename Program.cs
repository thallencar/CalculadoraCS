using System;
using System.Buffers;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1. Obter por meio do usuário qual será a operação desejada, dois números e depois informar o resultado. (✔)
            2. Após a aplicação informar o resultado, deverá ser perguntado ao usuário se ele deseja 
            fazer uma nova operação ou encerrar o programa (✔)
            3. Ao invés do usuário informar qual será a operação, ele deve formular a conta da seguinte
            forma: “numero” “sinal da operação” “numero” (X)
            4. Calculadora ano bissexto (✔)
            */

            MenuOperations();

        }

        static void Calculator (string option) { 
            Console.WriteLine("Digite um número");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número");
            float num2 = float.Parse(Console.ReadLine());

            float resultado = 0;

            switch (option)
            {
                case "1":
                    resultado = num1 + num2;
                    Console.WriteLine($"O resultado da operação é {resultado}");
                    break;
                case "2":
                    resultado = num1 - num2;
                    Console.WriteLine($"O resultado da operação é {resultado}");
                    break;
                case "3":
                    resultado = num1 * num2;
                    Console.WriteLine($"O resultado da operação é {resultado}");
                    break;
                case "4":
                    resultado = num1 / num2;
                    Console.WriteLine($"O resultado da operação é {resultado}");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
        static void MenuOperations()
        {
            while (true)
            {

                Console.WriteLine(@"
Digite a opção desejada.

MENU DE OPERAÇÕES:

1 - Adição
2 - Subtração
3 - Multiplicação
4 - Divisão
                ");

                string option = Console.ReadLine();
                Calculator(option);

                Console.WriteLine(@"
Deseja continuar no programa?
                       
1 - SIM
2 - NÃO
                ");

                string loopContinuation = Console.ReadLine();

                if (loopContinuation == "1")
                {
                    MenuOperations();

                } else if (loopContinuation == "2")
                {
                    break;
                }else
                {
                    Console.WriteLine("Número inválido.");
                    loopContinuation = Console.ReadLine();
                }
            }
           
        }
    }
}
