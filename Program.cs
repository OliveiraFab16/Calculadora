using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string escolha, sair;

            try
            {
                do
                {
                    Console.Clear();

                    Console.WriteLine("<------Calculadora Simples------>\n");

                    Console.WriteLine("<------Operações Basicas------>");
                    Console.WriteLine("Soma: +");
                    Console.WriteLine("Subtração: -");
                    Console.WriteLine("Multiplicação: *");
                    Console.WriteLine("Divisão: /");
                    Console.WriteLine("Potenciação: P");
                    Console.WriteLine("Radiação (Raiz Quadrada): R\n");
                    Console.Write("Escolha a Operação que Deseja Utilizar: ");
                    escolha = Console.ReadLine().ToUpper();

                    if (escolha == "+")
                    {
                        soma();
                    }

                    if (escolha == "-")
                    {
                        subtracao();
                    }

                    if (escolha == "*")
                    {
                        multiplicacao();
                    }

                    if (escolha == "/")
                    {
                        divisao();
                    }

                    if (escolha == "P")
                    {
                        potencia();
                    }

                    if (escolha == "R")
                    {
                        raiz();
                    }

                    Console.Write("Deseja Sair? S/N: ");
                    sair = Console.ReadLine().ToUpper();
                }
                while (sair != "S" && sair != "SIM");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine();
                Console.WriteLine("Não é possível dividir por zero.");
                Console.WriteLine("Pressione Enter para sair!");
                Console.ReadKey();
            }
            catch (OverflowException)
            {
                Console.WriteLine();
                Console.WriteLine("Número inválido.");
                Console.WriteLine("Pressione Enter para sair!");
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Número em formato inválido.");
                Console.WriteLine("Pressione Enter para sair!");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(); 
                Console.WriteLine($"Erro genérico: {ex.Message}");
                Console.WriteLine("Pressione Enter para sair!");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine("Obrigado por ultilizar meu programa :)");
        }
        static void soma()
        {
            double numero1, numero2, resultado;

            Console.Clear();

            Console.Write("Digite o 1ºValor: ");
            numero1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o 2ºValor: ");
            numero2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            resultado = numero1 + numero2;
            Console.WriteLine($"O resultado de {numero1} + {numero2} = {resultado}");
            Console.WriteLine();
        }

        static void subtracao()
        {
            double numero1, numero2, resultado;

            Console.Clear();

            Console.Write("Digite o 1ºValor: ");
            numero1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o 2ºValor: ");
            numero2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            resultado = numero1 - numero2;
            Console.WriteLine($"O resultado de {numero1} - {numero2} = {resultado}");
            Console.WriteLine();
        }

        static void multiplicacao()
        {
            double numero1, numero2, resultado;

            Console.Clear();

            Console.Write("Digite o 1ºValor: ");
            numero1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o 2ºValor: ");
            numero2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            resultado = numero1 * numero2;
            Console.WriteLine($"O resultado de {numero1} * {numero2} = {resultado}");
            Console.WriteLine();
        }

        static void divisao()
        {
            double numero1, numero2, resultado;

            Console.Clear();

            Console.Write("Digite o 1ºValor: ");
            numero1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o 2ºValor: ");
            numero2 = double.Parse(Console.ReadLine());

            if (numero2 == 0)
            {
                throw new DivideByZeroException("Não é possível dividir por zero.");
            }

            Console.WriteLine();
            resultado = numero1 / numero2;

            Console.WriteLine($"O resultado de {numero1} / {numero2} = {resultado}");
            Console.WriteLine();
        }

        static void potencia()
        {
            double numero1, numero2, resultado;

            Console.Clear();

            Console.Write("Digite o 1ºValor: ");
            numero1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o 2ºValor: ");
            numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine();
            resultado = numero1 * numero2 / 100;

            Console.WriteLine($"O resultado de {numero1} * {numero2} / 100 = {resultado}%");
            Console.WriteLine();
        }

        static void raiz()
        {
            double raizQuadrada, resultado;

            Console.Clear();

            Console.Write("Digite o Valor de Raiz Quadrada: ");
            raizQuadrada = double.Parse(Console.ReadLine());
            Console.WriteLine();

            resultado = Math.Sqrt(raizQuadrada);
            Console.WriteLine($"A raiz quadrada de {raizQuadrada} é = {Math.Round(resultado, 2)}");
        }
    }
}
