using System;

namespace calculadora_objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0, numero2 = 0, resultado = 0;

            Console.Clear();
            Console.WriteLine("Calculadora Digital");
            Console.WriteLine();
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine();

            int opcao = int.Parse(Console.ReadLine());

            if (opcao > 0 && opcao < 5)
            {
                Console.Write("Digite o primeiro número: ");
                numero1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                numero2 = int.Parse(Console.ReadLine());
            }


            Calculadora calc = new Calculadora();

            switch (opcao)
            {
                case 1:
                    resultado = calc.Somar(numero1, numero2);
                    Console.WriteLine("O resultado da soma é {0}", resultado);
                    break;
                case 2:
                    resultado = calc.Subtrair(numero1, numero2);
                    Console.WriteLine("O resultado da subtração é {0}", resultado);
                    break;
                case 3:
                    resultado = calc.Multiplicar(numero1, numero2);
                    Console.WriteLine("O resultado da multiplicação é {0}", resultado);
                    break;
                case 4:
                    resultado = calc.Dividir(numero1, numero2);
                    Console.WriteLine("O resultado da divisão é {0}", resultado);
                    break;
                default:
                    Console.WriteLine("Você digitou uma opção inválida");
                    break;
            }

        }
    }
}
