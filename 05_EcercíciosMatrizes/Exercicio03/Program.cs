namespace Exercicio03 {
    internal class Program {
        static void Main(string[] args) {
            int[,] matriz = new int[4, 4];

            // Recebe os valores e preenche a matriz
            for (int coluna = 0; coluna < 4; coluna++) {
                for (int linha = 0; linha < 4; linha++) {
                    Console.Write($"Informe o valor da coluna {coluna + 1} - linha {linha + 1} : ");
                    int valor = int.Parse(Console.ReadLine());
                    matriz[linha, coluna] = valor;
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

            Console.WriteLine("Os elementos da diagonal principal:");

            for (int i = 0; i < 4; i++) {
                Console.Write($"\n{matriz[i, i]}\n");
            }           



            Console.ReadKey();
        }
    }
}