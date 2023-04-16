namespace Exercicio07 {
    internal class Program {
        static void Main(string[] args) {
            int[] vetor = new int[10] { 7, -9, 25, 0, 24, 4, 3, 1, 9, 2 };

            for (int i = 0; i < vetor.Length; i++) {
                if (vetor[i] % 2 == 0) {
                    Console.Write($"| {vetor[i]} ");
                }
            }

            for (int i = 0; i < vetor.Length; i++) {
                if (vetor[i] % 2 != 0) {
                    Console.Write($"| {vetor[i]} ");
                }
            }
        }
    }
}