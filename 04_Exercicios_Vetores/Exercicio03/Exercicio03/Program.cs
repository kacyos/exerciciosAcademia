namespace Exercicio03 {
    internal class Program {
        static void Main(string[] args) {
            Random numeroAleatorio = new Random();
            int[] vetor = new int[20];
            

            for (int i = 0; i < vetor.Length; i++) {
                int divisores = 0;
                vetor[i] = numeroAleatorio.Next(2, 23);

                for (int j = 2; j <= vetor[i]; j++) {
                    if (vetor[i] % j == 0) {
                        divisores+=1;                      
                    }
                }
                
                if (divisores == 1) {
                    Console.WriteLine($"número: {vetor[i]} - posição {i}");
                }
            }
        }
    }
}