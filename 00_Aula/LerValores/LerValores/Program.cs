namespace LerValores {
    internal class Program {
        static void Main(string[] args) {

            for (;;) {

                Console.Write("Informe um valor: ");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao > 4 || opcao < 1) {
                    continue;
                } else {
                    break;
                }
            }
        }
    }
}