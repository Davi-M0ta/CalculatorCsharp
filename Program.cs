using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("CALCULADORA");
            Console.WriteLine("Selecione o tipo de operação que deseja realizar: ");
            Console.WriteLine("");
            Console.WriteLine("1 - Adição   2 - Subtração   3 - Multiplicação    4 - Divisão ");
            Console.WriteLine("5 - Raiz Quadrada   6 - Fatorial   7 - Potenciação");
            Console.WriteLine("");
            Console.WriteLine("0 - Sair");

            Console.WriteLine("");
            Console.Write("Operação: ");
            int selecao = int.Parse(Console.ReadLine()!);

            switch (selecao)
            {
                case 1: Addition(); break;
                case 2: Subtraction(); break;
                case 3: Multiplication(); break;
                case 4: Division(); break;
                case 5: SquareRoot(); break;
                case 6: Factorial(); break;
                case 7: Potentiation(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Addition()
        {
            Console.Clear();

            Console.Write("Primeiro Valor: ");
            float valor1 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Console.Write("Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine()!);

            Console.WriteLine("");
            Console.WriteLine("====================================");
            Console.WriteLine("");

            float resultado = valor1 + valor2;
            Console.WriteLine($"O resultado da soma de {valor1} e {valor2} é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Subtraction()
        {
            Console.Clear();

            Console.Write("Primeiro Valor: ");
            float valor1 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Console.Write("Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine()!);

            Console.WriteLine("");
            Console.WriteLine("====================================");
            Console.WriteLine("");

            float resultado = valor1 - valor2;
            Console.WriteLine($"O resultado da subtração de {valor1} e {valor2} é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplication()
        {
            Console.Clear();

            Console.Write("Primeiro Valor: ");
            float valor1 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Console.Write("Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine()!);

            Console.WriteLine("");
            Console.WriteLine("====================================");
            Console.WriteLine("");

            float resultado = (valor1 * valor2);
            Console.WriteLine($"O resultado da Multiplicação de {valor1} por {valor2} é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Division()
        {
            Console.Clear();

            Console.Write("Primeiro Valor: ");
            float valor1 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Console.Write("Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine()!);

            Console.WriteLine("");
            Console.WriteLine("====================================");
            Console.WriteLine("");

            float resultado = (valor1 / valor2);
            Console.WriteLine($"O resultado da Divisão de {valor1} por {valor2} é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void SquareRoot()
        {
            Console.Clear();

            Console.Write("Valor: ");
            double valor1 = float.Parse(Console.ReadLine()!);

            Console.WriteLine("");
            Console.WriteLine("====================================");
            Console.WriteLine("");

            double resultado = (Math.Sqrt(valor1));
            Console.WriteLine($"O resultado da Raiz Quadrada de {valor1} é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Factorial()
        {
            Console.Clear();

            Console.Write("Valor: ");
            int valor = int.Parse(Console.ReadLine()!);

            Console.WriteLine("");
            Console.WriteLine("====================================");
            Console.WriteLine("");

            int fatorial;

            for (fatorial = 1; valor > 1; valor--)
            {
                fatorial = fatorial * valor;
            }

            Console.WriteLine($"O resultado do fatorial é: {fatorial}");
            Console.ReadKey();
            Menu();
        }

        static void Potentiation()
        {
            Console.Clear();

            Console.Write("Insira o valor da base: ");
            int valor = int.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Console.Write("A qual valor deseja elevar ele? ");
            int potencia = int.Parse(Console.ReadLine()!);

            Console.WriteLine("");
            Console.WriteLine("====================================");
            Console.WriteLine("");

            double resultado = Math.Pow(valor, potencia);

            Console.WriteLine($"O resultado da potenciação é: {resultado}");
            Console.ReadKey();
            Menu();
        }
    }
}