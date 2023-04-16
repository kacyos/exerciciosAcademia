namespace Exercicio13 {
    internal class Program {
        static void Main(string[] args) {
            int[] vetor = new int[100];
            int dois = 0;
            int quatro = 0;
            int oito = 0;


            for (int i = 0; i < vetor.Length; i++) {            
                Console.WriteLine("Informe um número");
                int numero = int.Parse(Console.ReadLine());
                
                vetor[i] = numero;

                if (numero == -1) {
                    break;
                } else if (numero == 2) {
                    dois++;
                } else if (numero == 4) {
                    quatro++;
                } else if (numero == 8) {
                    oito++;
                }

                Console.WriteLine($"Número 2 digitado: {dois} vez(es)");
                Console.WriteLine($"Número 4 digitado: {quatro} vez(es)");
                Console.WriteLine($"Número 2 digitado: {oito} vez(es)");
            }
        }
    }
}