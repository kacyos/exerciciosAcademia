namespace Exercicio14 {
    internal class Program {
        static void Main(string[] args) {
            Random random = new Random();
            int[,] matriz = new int[4, 4];
            bool igual = false;

            // Recebe os valores e preenche a matriz
            for (int coluna = 0; coluna < 4; coluna++) {
                for (int linha = 0; linha < 4; linha++) {
                    matriz[linha, coluna] = random.Next(1, 10);
                }
            }

            // imprime a matriz completa
            for (int linha = 0; linha < 4; linha++) {
                for (int coluna = 0; coluna < 4; coluna++) {
                    Console.Write($"{matriz[linha, coluna]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            int j = 3;
            for (int i = 0; i < 4; i++) {
                igual = matriz[i, j] == matriz[i, i] ? true : false;
                j -= 1;
            }

            

            if (igual) {
                Console.WriteLine($"Os elementos da diagonal principal são iguais aos elementos da diagonal secundaria.");
            } else {
                Console.WriteLine($"Os elementos da diagonal principal não são iguais aos elementos da diagonal secundaria.");
            }



            Console.ReadKey();
        }
    }
}