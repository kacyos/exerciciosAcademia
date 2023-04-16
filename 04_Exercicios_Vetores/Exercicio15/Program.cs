namespace Exercicio15 {
    internal class Program {
        static void Main(string[] args) {
            Random random = new Random();
            int[] vetor = new int[20];
            int[] vetorCopia = new int[vetor.Length];

            // Popular vetor principal e exibir valores
            Console.WriteLine("\nArray original:\n");
            for (int i = 0; i < vetor.Length; i++) {
                int numero = random.Next(1, 50);
                vetor[i] = numero;
                Console.Write($" {vetor[i]} | ");
            }

            // realiza cópia do vetor
            Array.Copy(vetor, vetorCopia, vetor.Length);

            // inverte a ordem do vetorCopia
            Array.Reverse(vetorCopia);

            Console.WriteLine("\n\nArray invertido:\n");
            for (int i = 0; i < vetorCopia.Length; i++) {
                Console.Write($" {vetorCopia[i]} | ");
            }

            Console.ReadKey();
        }
    }
}