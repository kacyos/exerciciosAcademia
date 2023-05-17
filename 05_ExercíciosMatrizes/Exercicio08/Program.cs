namespace Exercicio08 {
    internal class Program {
        static void Main(string[] args) {
            Random random = new Random();
            int[,] matriz = new int[3, 3];

            for (int linha = 0; linha < 3; linha++) {
                for (int coluna = 0; coluna < 3; coluna++) {
                    matriz[linha, coluna] = random.Next(3, 50);
                }
            }

            Console.WriteLine("\nOrdem direta: ");
            for (int linha = 0; linha < 3; linha++) {
                for (int coluna = 0; coluna < 3; coluna++) {
                    Console.Write($"{matriz[linha, coluna]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nOrdem inversa: ");
            for (int linha = 2; linha >= 0; linha--) {
                for (int coluna = 2; coluna >= 0; coluna--) {
                    Console.Write($"{matriz[linha, coluna]}\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}