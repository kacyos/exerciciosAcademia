namespace Exercicio04 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe uma data no formato DDMMAAAA: ");
            string data = Console.ReadLine();

            string dia = data.Substring(0, 2);
            string mes = data.Substring(2, 2);
            string ano = data.Substring(4, 4);

            Console.WriteLine($"Data no formato AAAAMMDD: {ano} {mes} {dia}");
            Console.WriteLine($"Data no formato AAMMDD: {ano.Substring(2, 2)} {mes} {dia}");

            Console.ReadKey();
        }
    }
}