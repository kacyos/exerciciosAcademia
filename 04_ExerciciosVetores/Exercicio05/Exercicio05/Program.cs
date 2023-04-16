namespace Exercicio05 {
    internal class Program {
        static void Main(string[] args) {
            Random random = new Random();
            int[] vetor = new int[10];
            int menor = 0;
            int posicao = 0;
            
            for (int i = 0; i < vetor.Length; i++) {
                vetor[i] = random.Next(1, 85);                               
            }

            for (int i = 0; i < vetor.Length; i++) {
                Console.WriteLine(vetor[i]);
                if (i == 0) {
                    menor = vetor[i];
                    posicao = i;
                } 
                
                if (vetor[i] <= menor) {
                    menor = vetor[i];
                    posicao = i;
                }
            }

           
            Console.WriteLine($"\nMenor elemento: {menor} - Posição: {posicao}");
        }
    }
}