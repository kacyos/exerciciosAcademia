namespace Exercicio02 {
    internal class Program {
        static void Main(string[] args) {
            int[,] matriz = new int[3, 3];
            int somaLinha, somaColuna;

            //Popula a matriz
            for (int coluna = 0; coluna < 3; coluna++) {
                for (int linha = 0; linha < 3; linha++) {
                    Console.Write($"informe o valor da Coluna: {coluna + 1} - linha: {linha + 1}:  ");
                    matriz[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();

            //faz a soma das linhas e exibe a matriz
            for (int linha = 0; linha < 3; linha++) {
                 somaLinha = 0;

                for (int coluna = 0; coluna < 3; coluna++) {
                    somaLinha += matriz[linha, coluna];                    
                    Console.Write($"{matriz[linha, coluna]}\t");                   
                }

                Console.Write($"soma = {somaLinha}");
                               
                Console.WriteLine();              
            }

            Console.Write("______________________\n");
            //Realiza a soma das colunas
            for (int linha = 0; linha < 3; linha++) {
                somaColuna = 0;
                for (int coluna = 0; coluna < 3; coluna++) {
                    somaColuna += matriz[coluna, linha];  
                }
                Console.Write($"{somaColuna}\t");
            }


            Console.ReadKey();
        }
    }
}