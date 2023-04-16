namespace Exercicio07 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe o número do vendedor: #");
            int numeroVendedor = int.Parse(Console.ReadLine());

            Console.Write("Informe o salário fixo: R$");
            double salarioFixo = double.Parse(Console.ReadLine());

            Console.Write("Informe o total de vendas: ");
            int totalVendas = int.Parse(Console.ReadLine());

            Console.Write("Informe o percentual ganho sobre as vendas: ");
            double percentual = double.Parse(Console.ReadLine());

            string salarioTotal = (((percentual / 100) * salarioFixo) + salarioFixo ).ToString("N2");

            Console.WriteLine("\n**********************");

            Console.WriteLine($"Número do vendedor: {numeroVendedor}\nSalário total: {salarioTotal}");

            Console.ReadKey();
        }
    }
}