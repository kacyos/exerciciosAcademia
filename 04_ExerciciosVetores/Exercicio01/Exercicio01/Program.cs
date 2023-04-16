namespace Exercicio01 {
    internal class Program {
        static void Main(string[] args) {
            int[] vetor = new int[10] {1, 3, 5, 18, 20, 33, 4, 8, 14, 38};
            int numerosPares = 0;
            int numerosImpares = 0;

            for (int i = 0; i < vetor.Length; i++) {
                if (vetor[i] % 2 == 0) {
                    numerosPares++;
                } else {
                    numerosImpares++;
                }              
            }

            Console.WriteLine($"\nQuantidade de números pares: {numerosPares}\nQuantidade de números impares: {numerosImpares}\n");

        }
    }
}