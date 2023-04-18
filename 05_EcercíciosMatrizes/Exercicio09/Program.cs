namespace Exercicio09 {
    internal class Program {
        static void Main(string[] args) {
            Random random = new Random();
            int[,] matriz = new int[3, 3];
            int numero;
            bool correto = false;

            for (int linha = 0; linha < 3; linha++) {
                for (int coluna = 0; coluna < 3; coluna++) {
                    matriz[linha, coluna] = random.Next(0, 20);
                }
            }

            Console.Write("Adivinhe se o número está na matriz: ");
            numero = int.Parse(Console.ReadLine());

            for (int linha = 0; linha < 3; linha++) {
                for (int coluna = 0; coluna < 3; coluna++) {
                    if (matriz[linha, coluna] == numero) {
                        correto = true;
                    }
                }
            }

            if (correto) {
                Console.WriteLine("O número existe no vetor");
            } else {
                Console.WriteLine("Número inexistente");
            }

            Console.ReadKey();
        }
    }
}