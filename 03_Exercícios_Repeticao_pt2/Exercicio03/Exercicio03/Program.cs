namespace Exercicio03 {
    internal class Program {
        static void Main(string[] args) {
            while (true) {
                Console.Write("Informe um número: ");
                int numero = int.Parse(Console.ReadLine());
                string mensagem = "e é primo";

                if (numero == 0) {
                    break;
                }

                for (int i = 2; i < numero; i++) {
                    if (numero % i == 0) {
                        mensagem = "e não é primo";
                    }
                }

                if (numero % 2 == 0) {
                    Console.WriteLine($"O número {numero} é par {mensagem}");
                } else {
                    Console.WriteLine($"O número {numero} é impar {mensagem}");
                }


            }
        }
    }
}