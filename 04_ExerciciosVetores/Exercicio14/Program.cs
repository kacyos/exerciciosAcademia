namespace Exercicio14 {
    internal class Program {
        static void Main(string[] args) {
            Random random = new Random();
            int[] vetor = new int[50];

            // popular vetor com 50 números aleatórios
            for (int i = 0; i < vetor.Length; i++) {
                vetor[i] = random.Next(1, 100);
            }

            while (true) {
                Console.WriteLine("\nDigite 1 para exibir o vetor");
                Console.WriteLine("Digite 2 para exibir o vetor na ordem inversa");
                Console.WriteLine("Digite 0 para sair");
                Console.Write('\n');

                char opcao = char.Parse(Console.ReadLine());

                if (opcao == '0') {
                    break;
                }

                switch (opcao) {
                    case '1':
                        Console.Write('\n');
                        for (int i = 0; i < vetor.Length; i++) {
                            Console.Write($"{vetor[i]} |");
                        }
                        Console.Write('\n');
                        break;
                    case '2':
                        Console.Write('\n');
                        for (int i = vetor.Length - 1; i >= 0; i--) {
                            Console.Write($"{vetor[i]} |");
                        }
                        Console.Write('\n');
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida.\n");
                        break;
                }
            }
        }
    }
}