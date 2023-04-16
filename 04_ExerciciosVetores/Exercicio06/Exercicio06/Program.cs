namespace Exercicio06 {
    internal class Program {
        static void Main(string[] args) {
            int[] vetor = new int[10];

            for (int i = 0; i < vetor.Length; i++) {
                Console.Write($"Escreva o {i + 1}º número: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            for (int i = vetor.Length - 1; i >= 0; i--) {
                Console.Write($"| {vetor[i]} |");
            }
        }
    }
}