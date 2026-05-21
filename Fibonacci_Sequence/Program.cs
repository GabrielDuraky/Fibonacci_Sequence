using System;
using System.Collections.Generic;
using System.Numerics;

namespace Fibonacci_Sequence
{
    public static class Program
    {
        private const int MAX_POSITION = 10000; // Limite para evitar cálculos excessivos
        public static void Main(string[] args)
        {
            Console.WriteLine("Sequencia de Fibonacci:\n");
            Console.WriteLine($"Posição máxima permitida: {MAX_POSITION}");

            while (true)
            {
                Console.WriteLine("\nDigite um número inteiro para obter a sequencia de Fibonacci correspondente (ou 'sair' para encerrar):");
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input) ||
                    input.Trim().Equals("sair", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Saindo do programa.");
                    break;
                }

                if (!int.TryParse(input, out int n) || n < 0)
                {
                    Console.WriteLine("Por favor, digite um número inteiro não negativo válido.");
                    continue;
                }

                if (n > MAX_POSITION)
                {
                    Console.WriteLine($"Por favor, digite um número menor ou igual a {MAX_POSITION} para evitar cálculos excessivos.");
                    continue;
                }

                var sequence = Fibonacci.GetSequence(n);
                
                Console.WriteLine($"\nSequência até o número {n}:");
                Console.WriteLine(string.Join(", ", sequence));
                Console.WriteLine();
            }
        }
        public static class Fibonacci
        {
            public static List<BigInteger> GetSequence(int n)
            {
                var sequence = new List<BigInteger>();

                if (n < 0) return sequence;

                sequence.Add(0); // F0 = 0

                if (n == 0) return sequence;

                sequence.Add(1); // F1 = 1

                for (int i = 2; i <= n; i++)
                {
                    BigInteger next = sequence[i - 1] + sequence[i - 2];
                    sequence.Add(next);
                }
                return sequence;
            }
        }
    }
}