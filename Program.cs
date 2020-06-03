using System;

namespace Aula09Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Calculadora pi = new Calculadora();
            
            string resposta = null;
            
            do{
                System.Console.WriteLine("\nSelecione uma opção:\n");
                System.Console.WriteLine("1 - Somar");
                System.Console.WriteLine("2 - Subtrair");
                System.Console.WriteLine("3 - Dividir");
                System.Console.WriteLine("4 - Multiplicar");
                System.Console.WriteLine("5 - Média");
                System.Console.WriteLine("0 - Sair");
                resposta = Console.ReadLine();

                switch(resposta){
                    case "1":
                    Console.Clear();
                    System.Console.WriteLine("Digite o primeiro número:");
                    pi.num[0] = Double.Parse(Console.ReadLine());
                    System.Console.WriteLine("Digite o segundo número:");
                    pi.num[1] = Double.Parse(Console.ReadLine());
                    System.Console.WriteLine($"\nSeu resultado da soma é {pi.Soma()}.");
                    break;
                    case "2":
                    Console.Clear();
                    System.Console.WriteLine("Digite o primeiro número:");
                    pi.num[0] = Double.Parse(Console.ReadLine());
                    System.Console.WriteLine("Digite o segundo número:");
                    pi.num[1] = Double.Parse(Console.ReadLine());
                    System.Console.WriteLine($"\nSeu resultado da subtração é {pi.Subtracao()}.");
                    break;
                    case "3":
                    Console.Clear();
                    System.Console.WriteLine("Digite o primeiro número:");
                    pi.num[0] = Double.Parse(Console.ReadLine());
                    System.Console.WriteLine("Digite o segundo número:");
                    pi.num[1] = Double.Parse(Console.ReadLine());
                    System.Console.WriteLine($"\nSeu resultado da divisão é {pi.Divisao()}.");
                    break;
                    case "4":
                    Console.Clear();
                    System.Console.WriteLine("Digite o primeiro número:");
                    pi.num[0] = Double.Parse(Console.ReadLine());
                    System.Console.WriteLine("Digite o segundo número:");
                    pi.num[1] = Double.Parse(Console.ReadLine());
                    System.Console.WriteLine($"\nSeu resultado da multiplicação é {pi.Multiplicacao()}.");
                    break;
                    case "5":
                    Console.Clear();
                    System.Console.WriteLine("Digite os números:");
                    
                    break;

                    case "0":
                    System.Console.WriteLine("Obrigado por usar minha calculadora.");
                    break;

                    default:
                    System.Console.WriteLine("Digite uma opção novamente");
                    break;
                }
            }while(resposta != "0");
            
        }
    }
}
