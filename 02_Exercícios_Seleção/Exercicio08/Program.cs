namespace Exercicio08 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe o código: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Informe o nome do funcionário: ");
            string nome = Console.ReadLine();

            Console.Write("Informe o salário base: R$ ");
            double salarioBase = double.Parse(Console.ReadLine());

            Console.Write("Informe o total de vendas: R$ ");
            double totalDeVendas = double.Parse(Console.ReadLine());

            double acrescimo = 0;

            if (totalDeVendas > 5000) {
                acrescimo = (totalDeVendas * 0.10) / 100;
            } else if (totalDeVendas > 1000) {
                acrescimo = totalDeVendas * 0.07;
            } else {
                acrescimo = (totalDeVendas * 0.05) / 100;
            }
            Console.WriteLine(acrescimo);
            Console.WriteLine($"Código: {codigo}\nNome: {nome}\nSalário base: R$ {salarioBase}\nTotal de vendas: R$ {totalDeVendas}\nSalário final: {acrescimo + salarioBase}");
            Console.ReadKey();
        }
    }
}