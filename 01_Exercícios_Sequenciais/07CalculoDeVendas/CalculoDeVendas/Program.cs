namespace CalculoDeVendas {
    internal class Program {
        static void Main(string[] args) {

            int sellerNumber;
            double salary, percentage, totalSalary, salesAmount;

            Console.Write("Escreva o número do vendedor: ");
            sellerNumber = int.Parse(Console.ReadLine());

            Console.Write("Escreva o total de vendas: ");
            salesAmount = int.Parse(Console.ReadLine());

            Console.Write("Escreva o salário fixo do vendedor: ");
            salary = double.Parse(Console.ReadLine());

            Console.Write("Escreva o percentual sobre as vendas: ");
            percentage = double.Parse(Console.ReadLine());

            totalSalary = salary + (salesAmount * (percentage / 100));

            Console.WriteLine($"\n\nO Salário do vendedor nº {sellerNumber} é R$ {totalSalary}");

        }
    }
}