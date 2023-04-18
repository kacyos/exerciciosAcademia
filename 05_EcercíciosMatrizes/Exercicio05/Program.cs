namespace Exercicio05 {
    internal class Program {
        static void Main(string[] args) {
            Random random = new Random();
            int [,] matriz01= new int[4,4];
            int [,] matriz02= new int[4,4];
            int [,] matrizSoma= new int[4,4];

            for (int linha = 0; linha < 4; linha++) {
                for (int coluna = 0; coluna < 4; coluna++) {
                    matriz01[linha, coluna] = random.Next(5, 30);
                    matriz02[linha, coluna] = random.Next(10, 40);                    
                }
            }

            /********** Exibe as matrizes ******/
            Console.WriteLine("Matriz 01: \n");
            for (int linha = 0; linha < 4; linha++) {
                for (int coluna = 0; coluna < 4; coluna++) {
                    Console.Write($"{matriz01[linha, coluna]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMatriz 02: \n");
            for (int linha = 0; linha < 4; linha++) {
                for (int coluna = 0; coluna < 4; coluna++) {
                    Console.Write($"{matriz02[linha, coluna]}\t");
                }
                Console.WriteLine();
            }
            /************************************/

            Console.WriteLine("\n\nSoma das matrizes: \n");
            /* Exibe a soma das duas matrizes */
            for (int linha = 0; linha < 4; linha++) {
                for (int coluna = 0; coluna < 4; coluna++) {
                    matrizSoma[linha, coluna] = matriz01[linha, coluna] + matriz02[linha, coluna];
                    Console.Write($"{matrizSoma[linha, coluna]}\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}