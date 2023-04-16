using System;

namespace Exercicio01 {
    internal class Program {
        static void Main(string[] args) {
            for (; ; ) {
                Console.Write("Informe um número inteiro: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero < 0) {
                    Console.WriteLine($"Digite um número inteiro positivo: {numero}");
                    continue;
                }

                Console.Write($"Números inteiros pares entre 1 e {numero}: ");

                for (int i = 2; i <= numero; i += 2) {
                    Console.Write($"{i} ");
                }

                break;
            }
        }
    }
}