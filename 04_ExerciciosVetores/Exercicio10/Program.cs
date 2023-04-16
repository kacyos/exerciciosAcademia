using System.Collections.Immutable;

namespace Exercicio10 {
    internal class Program {
        static void Main(string[] args) {
            Random random = new Random();
            int[] vetor = new int[20];
            int[] novoVetor = new int[20];

            Console.WriteLine("Vetor original: ");
            for (int i = 0; i < vetor.Length; i++) {
                vetor[i] = random.Next(0, 10);

                if (vetor[i] == 0) {
                    novoVetor[i] = 2;
                } else {
                    novoVetor[i] = vetor[i];
                }

                Console.Write($"{vetor[i]} | ");
            }

            Console.WriteLine("\n\nVetor modificado");
            for (int i = 0; i < novoVetor.Length; i++) {
                Console.Write($"{novoVetor[i]} | ");
            }

            Console.ReadKey();
        }
    }
}