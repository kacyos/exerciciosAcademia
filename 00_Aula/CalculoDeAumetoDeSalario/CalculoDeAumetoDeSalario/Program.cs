namespace CalculoDeAumetoDeSalario {
    internal class Program {
        static void Main(string[] args) {
            double salario, valorDoAumento, porcentagem, novoSalario ;

            Console.Write("Digite o valor do salário: ");
            salario = double.Parse(Console.ReadLine());

            if(salario <= 900) {
                valorDoAumento = 0.05 * salario;
                novoSalario = valorDoAumento + salario;
                porcentagem = 5;

            } else if (salario < 1400) {
                valorDoAumento = 0.08 * salario;
                novoSalario = valorDoAumento + salario;
                porcentagem = 8;

            } else  {
                valorDoAumento = 0.10 * salario;
                novoSalario = valorDoAumento + salario;
                porcentagem = 10;               
            }

            Console.Write($"\nA porcentagem do aumento é de: {porcentagem}%" +
                   $"\nO Valor do aumento é de: {valorDoAumento}" +
                   $"\nO novo salário é de: {novoSalario}\n\n");

        }
    }
}