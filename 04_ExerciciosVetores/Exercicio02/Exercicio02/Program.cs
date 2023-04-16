namespace Exercicio02 {
    internal class Program {
        static void Main(string[] args) {
            Random randomNumber = new Random();
            int[] vetor01 = new int[20];
            int[] vetor02 = new int[20];
            int[] somaVetores = new int[20];

            for (int i = 0; i < vetor01.Length; i++) {
                vetor01[i] = randomNumber.Next(100);
                vetor02[i] = randomNumber.Next(200);

                somaVetores[i] = vetor01[i] + vetor02[i];
                Console.WriteLine($"soma na posição {i} = {somaVetores[i]} ");
            }

            
        }
    }
}