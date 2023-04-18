namespace Desafio_01_JogoDaVelha {
    internal class Program {
        static void Main(string[] args) {
            string[,] tabuleiro = new string[3, 3];

            void desenharTabuleiro(string x = "i", string y = "i", string jogada = "-") {
                for (int coluna = 0; coluna < tabuleiro.GetLength(1); coluna++) {
                    Console.Write($"\t{coluna}");
                }

                Console.WriteLine();

                for (int linha = 0; linha < tabuleiro.GetLength(0); linha++) {

                    Console.Write($" {linha} |");

                    for (int coluna = 0; coluna < tabuleiro.GetLength(1); coluna++) {                        
                        if (x == "i" && y == "i") {
                            tabuleiro[linha, coluna] = "-"; 
                        } else {
                            tabuleiro[int.Parse(x), int.Parse(y)] = jogada;
                        }                        
                        Console.Write($"\t{tabuleiro[linha, coluna]}");
                    }
                    
                    Console.WriteLine();
                }
            }

            desenharTabuleiro();

            while (true) {
                Console.WriteLine("Vez do jogador 01:\n");
                Console.Write("Informe a linha da jogada: ");
                string linha = Console.ReadLine();
                Console.Write("Informe a coluna da jogada: ");
                string coluna = Console.ReadLine();
                desenharTabuleiro(linha, coluna, "X");

                Console.WriteLine("Vez do jogador 02:\n");
                linha = Console.ReadLine();
                Console.Write("Informe a coluna da jogada: ");
                coluna = Console.ReadLine();
                desenharTabuleiro(linha, coluna, "O");
            }

            
        }
    }
}