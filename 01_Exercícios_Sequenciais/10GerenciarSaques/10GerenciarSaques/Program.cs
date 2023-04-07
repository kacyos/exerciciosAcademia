namespace _10GerenciarSaques {
    internal class Program {
        static void Main(string[] args) {
            int valorSolicitado;

            Console.Write("Digite o valor a ser sacado: ");
            valorSolicitado = int.Parse(Console.ReadLine());

            int notas50 = valorSolicitado / 50;
            valorSolicitado = valorSolicitado % 50;

            int notas20 = valorSolicitado / 20;
            valorSolicitado = valorSolicitado % 20;

            int notas10 = valorSolicitado / 10;
            valorSolicitado = valorSolicitado % 10;

            int notas5 = valorSolicitado / 5;
            valorSolicitado = valorSolicitado % 5;

            int notas1 = valorSolicitado;

            Console.WriteLine("Notas de R$50: " + notas50);
            Console.WriteLine("Notas de R$20: " + notas20);
            Console.WriteLine("Notas de R$10: " + notas10);
            Console.WriteLine("Notas de R$5: " + notas5);
            Console.WriteLine("Notas de R$1: " + notas1);

        }
    }
}