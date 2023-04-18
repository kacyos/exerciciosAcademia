using System;

namespace Exercicio16 {
    internal class Program {
        static void Main(string[] args) {
            Random random = new Random();
            int[,] matrizA = new int[3, 4];
            int[,] matrizB = new int[4, 3];

            Console.WriteLine("Matriz original: 3x4");
            for (int linha = 0; linha < 3; linha++) {
                for (int coluna = 0; coluna < 4; coluna++) {
                    matrizA[linha, coluna] = random.Next(1, 20);
                    Console.Write($"{matrizA[linha,coluna]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMatriz transposta: 4x3");
            for (int linha = 0; linha < 4; linha++) {
                for (int coluna = 0; coluna < 3; coluna++) {
                    matrizB[linha, coluna] = matrizA[coluna, linha];
                    Console.Write($"{matrizB[linha, coluna]}\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}