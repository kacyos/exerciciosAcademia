﻿namespace Exercicio05 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            int fatorial = 1;

            for (int i = numero; i > 0; i--) {
                fatorial *= i;
            }

            Console.WriteLine($"O fatorial de {numero} é: {fatorial}");

            Console.ReadKey();
        }
    }
}