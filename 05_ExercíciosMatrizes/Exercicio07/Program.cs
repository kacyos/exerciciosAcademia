namespace Exercicio07 {
    internal class Program {
        static void Main(string[] args) {
            Random random = new Random();
            int[,] a = new int[3, 3]; 
            int[,] b = new int[3, 3];
            int[,] c = new int[3, 3];

            for (int linha = 0; linha < 3; linha++) {
                for (int coluna = 0; coluna < 3; coluna++) {
                    a[linha, coluna] = random.Next(5, 20);
                    b[linha, coluna] = random.Next(1, 10);
                    c[linha, coluna] = a[linha, coluna] - b[linha, coluna];
                }
            }

            Console.WriteLine("\nMatriz A: \n");

            for (int linha = 0; linha < 3; linha++) {
                for (int coluna = 0; coluna < 3; coluna++) {
                    Console.Write($"{a[linha, coluna]}\t");                    
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMatriz B: \n");

            for (int linha = 0; linha < 3; linha++) {
                for (int coluna = 0; coluna < 3; coluna++) {
                    Console.Write($"{b[linha, coluna]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMatriz C: \n");

            for (int linha = 0; linha < 3; linha++) {
                for (int coluna = 0; coluna < 3; coluna++) {
                    Console.Write($"{c[linha, coluna]}\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}