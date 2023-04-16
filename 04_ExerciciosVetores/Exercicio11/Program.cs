namespace Exercicio11 {
    internal class Program {
        static void Main(string[] args) {
            Random random = new Random();
            int[] vetor = new int[5];

            Console.WriteLine("Vetor em ordem: ");
            for (int i = 0; i < 5; i++) {
                vetor[i] = random.Next(0, 10);
                Console.Write($"{vetor[i]} | ");
            }

            Console.WriteLine("\n\nVetor em ordem inversa: ");
            for (int i = 4; i >= 0; i--) {
                Console.Write($"{vetor[i]} | ");
            }

            Console.Read();
        }
    }
}