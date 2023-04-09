namespace _13SalarioDoEmpregado {
    internal class Program {
        static void Main(string[] args) {
            
            Console.Write("Informe o valor do salário mínimo: ");
            double salarioMinimo = double.Parse(Console.ReadLine());

            Console.Write("Informe o preço de custo da bicicleta: ");
            double precoDeCusto = double.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade de bicicletas vendidas pelo vendedor: ");
            double bicicletasVendidas = double.Parse(Console.ReadLine());

            double salario = 2 * salarioMinimo;
            double comissao = ((bicicletasVendidas * precoDeCusto) * 0.15);
            salario = salario + comissao;

            Console.WriteLine($"O salário do empregado é: {salario.ToString("N2")}");

        }
    }
}