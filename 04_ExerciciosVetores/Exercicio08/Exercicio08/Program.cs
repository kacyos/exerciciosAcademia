namespace Exercicio08 {
    internal class Program {
        static void Main(string[] args) {
            Random random = new Random();
            double[] vetor = new double[30];

            for (int i = 0; i < vetor.Length; i++) {
                double numeroAleatorio = ((random.NextDouble() * 200) * (random.Next(0, 2) == 0 ? -1 : 1));
                vetor[i] = Math.Round(numeroAleatorio, 2);
            }

            for (int i = 0; i < vetor.Length; i++) {
                if (vetor[i] < 0) {
                    Console.Write($" | posição: {i}");
                }
            }
        }
    }
}