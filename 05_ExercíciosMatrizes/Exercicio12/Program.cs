namespace Exercicio12 {
    internal class Program {
        static void Main(string[] args) {
            Random random = new Random();
            int[,] matriz = new int[4, 3];

            for (int linha = 0; linha < 3; linha++) {
                for (int coluna = 0; coluna < 3; coluna++) {
                    matriz[linha, coluna] = random.Next(1, 10);
                }
            }

            for (int linha = 0; linha < 3; linha++) {
                for (int coluna = 0; coluna < 3; coluna++) {
                   
                    if ((linha + coluna + 2) % 2 == 0) {
                        Console.Write($"{matriz[linha, coluna]}\t");   
                    } else {
                        Console.Write("-\t");
                    }                                   
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}