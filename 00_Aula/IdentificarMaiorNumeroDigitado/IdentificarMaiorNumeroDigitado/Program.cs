namespace IdentificarMaiorNumeroDigitado {
    internal class Program {
        static void Main(string[] args) {
            int maiorNumero = 0;

            for (int i = 0; i < 10; i++) {
                Console.Write($"Digite {1+i}º número: ");
               int entrada = int.Parse(Console.ReadLine());

                if (entrada > maiorNumero) {
                    maiorNumero = entrada;
                }
            }

            Console.WriteLine(maiorNumero);
        }
    }
}