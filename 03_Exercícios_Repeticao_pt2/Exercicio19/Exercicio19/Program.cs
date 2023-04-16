namespace Exercicio19 {
    internal class Program {
        static void Main(string[] args) {
            double salario = 0;
            double maiorSalario = double.MinValue;
            int salarioMenorOuIgaulA100 = 0;
            double totalSalario = 0;
            int filhos = 0;
            int totalPopulacao = 0;


            while (true) {
                
                Console.Write($"Informe o salário da pessoa {totalPopulacao}: ");
                salario = double.Parse(Console.ReadLine());
                
                if (salario < 0) {
                    break;
                }

                Console.Write($"Informe o nº de filhos da pessoa {totalPopulacao}: ");
                filhos += int.Parse(Console.ReadLine());

                totalSalario += salario;

                if (salario > maiorSalario) {
                    maiorSalario = salario;
                } 
                
                if (salario <= 100) {
                    salarioMenorOuIgaulA100++ ;
                }

                totalPopulacao++;
            }

            Console.WriteLine($"A média do salário da população é: {totalSalario / totalPopulacao}");
            Console.WriteLine($"A média do número de filhos é: {filhos / totalPopulacao}");
            Console.WriteLine($"O maior salário é: {maiorSalario}");
            Console.WriteLine($"A média do número de filhos é: {filhos / totalPopulacao}");
            Console.WriteLine($"O percentual de pessoas com salário até R$ 100,00 é: {(salarioMenorOuIgaulA100 / totalPopulacao) * 100}");
        }
    }
}