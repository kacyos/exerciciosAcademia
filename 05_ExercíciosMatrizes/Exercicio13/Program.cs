using System.Globalization;

namespace Exercicio13 {
    internal class Program {
        static void Main(string[] args) {
            Random random = new Random();
            int[,] matriz = new int[4, 4];

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
            int somaPrincipal = 0;
            for (int i = 0; i < 4; i++) {
                somaPrincipal += matriz[i, i];
            }

            Console.WriteLine();
            int somaSecundaria = 0;
            int j = 0;
            for (int i = 3; i >= 0; i--) {
                somaSecundaria += matriz[j, i];
                j += 1;
            }

            if(somaPrincipal == somaSecundaria) {
                Console.WriteLine($"A soma da diagonal principal é igual a soma da diagonal secundaria: principal {somaPrincipal} - secundaria {somaSecundaria}");
            } else {
                Console.WriteLine($"A soma da diagonal principal não é igual a soma da diagonal secundaria: principal {somaPrincipal} - secundaria {somaSecundaria}");
            }



            Console.ReadKey();

        }
    }
}