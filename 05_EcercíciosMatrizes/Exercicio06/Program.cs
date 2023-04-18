namespace Exercicio06 {
    internal class Program {
        static void Main(string[] args) {
            Random random = new Random();
            int[,] matrizM = new int[4, 4];
            int maior = 0;

            for (int linha = 0; linha < 4; linha++) {
                for (int coluna = 0; coluna < 4; coluna++) {
                    matrizM[linha, coluna] = random.Next(0, 10);
                    if (matrizM[linha,coluna] > maior) {
                        maior = matrizM[linha,coluna];
                    }
                }
            }

            for (int linha = 0; linha < 4; linha++) {
                for (int coluna = 0; coluna < 4; coluna++) {
                    Console.Write($"{matrizM[linha, coluna]}\t");
                }
                Console.WriteLine();
            }

            Console.Write($"O maior número da matriz é: {maior}");
            Console.ReadKey();
        }
    }
}