using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu() {
            Console.Clear();

            Console.WriteLine(" - CALCULADORA -");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - soma");
            Console.WriteLine("2 - subtração");
            Console.WriteLine("3 - divisão");
            Console.WriteLine("4 - multiplicação");
            Console.WriteLine("5 - SAIR");
            Console.WriteLine(" ");
            Console.WriteLine("Selecione uma opção:");
            short res;
            while(!short.TryParse(Console.ReadLine(), out res))
            {
                Console.WriteLine("Valor inválido. Por favor, insira um número válido:");
            }

            switch(res){
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break; 
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma() {
            Console.WriteLine("Primeiro valor: ");
            float v1;
            while (!float.TryParse(Console.ReadLine(), out v1))
            {
                Console.WriteLine("Valor inválido. Por favor, insira um número válido:");
            }

            Console.WriteLine("Segundo valor:");
            float v2;
            while (!float.TryParse(Console.ReadLine(), out v2))
            {
                Console.WriteLine("Valor inválido. Por favor, insira um número válido:");
            }
            
            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao() {
            Console.WriteLine("Primeiro valor: ");
            float v1;
            while (!float.TryParse(Console.ReadLine(), out v1))
            {
                Console.WriteLine("Valor inválido. Por favor, insira um número válido:");
            }

            Console.WriteLine("Segundo valor:");
            float v2;
            while (!float.TryParse(Console.ReadLine(), out v2))
            {
                Console.WriteLine("Valor inválido. Por favor, insira um número válido:");
            }
            
            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao() {
            Console.WriteLine("Primeiro valor: ");
            float v1;
            while (!float.TryParse(Console.ReadLine(), out v1))
            {
                Console.WriteLine("Valor inválido. Por favor, insira um número válido:");
            }

            Console.WriteLine("Segundo valor:");
            float v2;
            while (!float.TryParse(Console.ReadLine(), out v2))
            {
                Console.WriteLine("Valor inválido. Por favor, insira um número válido:");
            }

            float resultado = v1/v2;
            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao() {
            Console.WriteLine("Primeiro valor: ");
            float v1;
            while(!float.TryParse(Console.ReadLine(), out v1))
            {
                Console.WriteLine("Valor inválido. Por favor, insira um número válido:");
            }

            Console.WriteLine("Segundo valor: ");
            float v2;
            while(!float.TryParse(Console.ReadLine(), out v2))
            {
                Console.WriteLine("Valor inválido. Por favor, insira um número válido:");
            }
            
            float resultado = v1*v2;
            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            Console.ReadKey();
            Menu();
        }
    }
}