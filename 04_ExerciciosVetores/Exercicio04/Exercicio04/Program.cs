namespace Exercicio04 {
    internal class Program {
        static void Main(string[] args) {
            Random random = new Random();
            int[] vetor01 = new int[10];
            int[] vetor02 = new int[10];
            int[] vetorMulti = new int[10];
            
            Console.WriteLine("\n");

            for (int i = 0; i < vetor01.Length; i++) { 
                vetor01[i] = random.Next(1, 30);
                vetor02[i] = random.Next(30, 68);
                vetorMulti[i] = vetor01[i] * vetor02[i];
                Console.Write($"| {i}: {vetorMulti[i]}");
            }

            Console.WriteLine("\n");
        }
    }
}