namespace Exercicio04 {
    internal class Program {
        static void Main(string[] args) {
           Random random = new Random();
           int[,] matriz = new int[4, 4];
            int pares = 0;
            int impares = 0;
            int positivos = 0;
            int negativos = 0;
            int zerados = 0;

            // Popula a matriz e faz as verificações
            for (int linha = 0; linha < 4; linha++) {
                for (int coluna = 0; coluna < 4; coluna++) {
                    matriz[linha, coluna] = random.Next(-5, 5);

                    if (matriz[linha, coluna] % 2 == 0) {
                        pares++;
                    }
                    if (matriz[linha, coluna] % 2 != 0) {
                        impares++;
                    }
                    if (matriz[linha,coluna] > 0) {
                        positivos++;
                    }
                    if (matriz[linha, coluna] < 0) {
                        negativos++;
                    }
                    if (matriz[linha, coluna] == 0) {
                        zerados++;
                    }
                }                
            }

            // Exibe a matriz;
            for (int linha = 0; linha < 4; linha++) {
                for (int coluna = 0; coluna < 4; coluna++) {

                    Console.Write($"{matriz[linha, coluna]}\t");
                }
                Console.WriteLine();
            }

            Console.Write($"\nTotal de pares: {pares}" +
                $"\nTotal de impares: {impares}" +
                $"\nTotal de positivos: {positivos}" +
                $"\nTotal de enegativos: {negativos}" +
                $"\nTotal de 0: {zerados}\n");
            Console.ReadKey();
        }
    }
}