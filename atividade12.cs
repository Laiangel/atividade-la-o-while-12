using System;

class Program
{
    static void Main(string[] args)
    {
        int pares = 0; // Contador de números pares
        int impares = 0; // Contador de números ímpares

        Console.WriteLine("Digite números inteiros. Digite 0 para encerrar.");

        while (true)
        {
            Console.Write("Digite um número: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                if (numero == 0)
                {
                    // Encerra o programa ao digitar 0
                    Console.WriteLine("Programa encerrado.");
                    break;
                }

                // Verifica se o número é par ou ímpar
                if (numero % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
            }
        }

        // Exibe os resultados
        Console.WriteLine($"\nTotal de números pares: {pares}");
        Console.WriteLine($"Total de números ímpares: {impares}");
    }
}

