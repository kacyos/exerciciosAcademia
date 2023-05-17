using System;

namespace Exercicio10 {
    internal class Program {
        static void Main(string[] args) {
            Random random = new Random();
            int[,] a = new int[4, 4];
            int[,] b = new int[4, 4];
            int abaixo = 0; 
            int acima = 0; 
            int naMedia = 0;
            int somaA = 0;
            int somaB = 0;
            double media;



            for (int linha = 0; linha < 3; linha++) {
                for (int coluna = 0; coluna < 3; coluna++) {
                    a[linha, coluna] = random.Next(1, 17);
                    b[linha, coluna] = random.Next(1, 32);
                }
            }

            for (int linha = 0; linha < 3; linha++) {
                for (int coluna = 0; coluna < 3; coluna++) {
                    somaA += a[linha, coluna];
                    somaB += b[linha, coluna]; ;
                }
            }

            media = ((somaA + somaB) / a.Length);

            for (int linha = 0; linha < 3; linha++) {
                for (int coluna = 0; coluna < 3; coluna++) {
                    if (media > a[linha, coluna]) {
                        abaixo ++;
                    } else if(media == a[linha, coluna] ) {
                        naMedia++;
                    } else {
                        acima++;
                    }

                    if (media > b[linha, coluna]) {
                        abaixo++;
                    } else if(media == b[linha, coluna]) {
                        naMedia++;
                    } else {
                        acima++;
                    }
                }
            }

            Console.WriteLine("Matriz A: ");
            for (int linha = 0; linha < 3; linha++) {
                for (int coluna = 0; coluna < 3; coluna++) {
                    Console.Write($"{a[linha, coluna]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Matriz B: ");
            for (int linha = 0; linha < 3; linha++) {
                for (int coluna = 0; coluna < 3; coluna++) {
                    Console.Write($"{b[linha, coluna]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine($"Média: {media}");
            Console.WriteLine();
            Console.WriteLine($"Elementos na média: {naMedia}");
            Console.WriteLine($"Elementos acima da média: {acima}");
            Console.WriteLine($"Elementos abaixo da média: {abaixo}");
            
            Console.ReadKey();
        }
    }
}