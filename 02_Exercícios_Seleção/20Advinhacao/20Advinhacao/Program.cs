

namespace _20Advinhacao {
    internal class Program {
        static void Main(string[] args) {
            Random r = new Random();
            int numeroSecreto = r.Next(1 , 51);
            int numeroDigitado;

            Console.WriteLine("Digite um número de 1 a 50 (Chance 1-3):");
            numeroDigitado = int.Parse(Console.ReadLine());

            if (numeroDigitado > numeroSecreto) {
                Console.WriteLine("Dica o número secreto é menor que o número digitado!");


            } else if (numeroDigitado < numeroSecreto) {
                Console.WriteLine("Dica o número secreto é maior que o número digitado!");
            } else {
                Console.WriteLine($"Parabéns você acertou o número secreto {numeroSecreto}");
                return;
            }

            Console.WriteLine("Digite um número de 1 a 50 (Chance 2-3):");
            numeroDigitado = int.Parse(Console.ReadLine());

            if (numeroDigitado > numeroSecreto) {
                Console.WriteLine("Dica o número secreto é menor que o número digitado!");


            } else if (numeroDigitado < numeroSecreto) {
                Console.WriteLine("Dica o número secreto é maior que o número digitado!");
            } else {
                Console.WriteLine($"Parabéns você acertou o número secreto {numeroSecreto}");
                return;
            }

            Console.WriteLine("Digite um número de 1 a 50 (Chance 3-3):");
            numeroDigitado = int.Parse(Console.ReadLine());

            if (numeroDigitado > numeroSecreto) {
                Console.WriteLine("Dica o número secreto é menor que o número digitado!");
                Console.WriteLine( "Você perdeu");

            } else if (numeroDigitado < numeroSecreto) {
                Console.WriteLine("Dica o número secreto é maior que o número digitado!");
                Console.WriteLine("Você perdeu");
            } else {
                Console.WriteLine($"Parabéns você acertou o número secreto {numeroSecreto}");
                return;
            }
        }
    }
}