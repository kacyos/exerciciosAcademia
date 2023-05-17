namespace Exercicio11 {
    internal class Program {
        static void Main(string[] args) {
            Random random = new Random();
            double[,] matriz = new double[3, 3];
            double[,] matrizB = new double[3, 3];

            for (int linha = 0; linha < 3; linha++) {
                for (int coluna = 0; coluna < 3; coluna++) {
                    matriz[linha, coluna] = Math.Round((random.NextDouble() * 100), 2);
                }
            }

            for (int linha = 0; linha < 3; linha++) {
                for (int coluna = 0; coluna < 3; coluna++) {
                    double result = Math.Round((matriz[linha, coluna] / (linha + coluna + 2)), 2);
                    matrizB[linha, coluna] = result;
                }
            }

            Console.WriteLine("Matriz original\n");
            for (int linha = 0; linha < 3; linha++) {
                for (int coluna = 0; coluna < 3; coluna++) {
                    Console.Write($"{matriz[linha, coluna]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\nMatriz resultante da divisão dos elementos da matriz A pela soma dos seus indices\n");

            for (int linha = 0; linha < 3; linha++) {
                for (int coluna = 0; coluna < 3; coluna++) {
                    Console.Write($"{matrizB[linha, coluna]}\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}