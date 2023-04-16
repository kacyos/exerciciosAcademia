namespace Exercicio09 {
    internal class Program {
        static void Main(string[] args) {
            int[] vetor = new int[10] { 15, 2, 187, 199, 3, 17, 32, 19, 1, 173 };
            int[] vetorAux = new int[10];

            Array.Copy(vetor, vetorAux, 10);
            Array.Sort(vetorAux);

            Console.WriteLine("Vetor inicial: ");
            for (int i = 0; i < vetor.Length; i++) {
                Console.Write($"{vetor[i]} | ");
            }

            Console.WriteLine("\n\nVetor ordenado: ");
            for (int i = 0; i < vetorAux.Length; i++) {
                Console.Write($"{vetorAux[i]} | ");
            }

            Console.ReadKey();
        }
    }
}