namespace Exercicio12 {
    internal class Program {
        static void Main(string[] args) {
            double extra = 20.00;
            double valorHora = 10.00;

            double horasExcedidas, salarioTotal, salario = 0;

            Console.Write("Informe o código do funcionário: ");
            string codigo = Console.ReadLine();

            Console.Write("Informe o número de horas trabalhadas: ");
            double numeroHoras = double.Parse(Console.ReadLine());

            if (numeroHoras > 50) {
                horasExcedidas = numeroHoras - 50;
                extra *= horasExcedidas;
                salario = (numeroHoras - horasExcedidas) * valorHora;
            } else {
                salario = numeroHoras * valorHora;
                extra = 0;
            }

            salarioTotal = extra + salario;

            Console.Write("\n*********************\n\n");
            Console.Write($"Código: {codigo}\nSalário total: R$ {salarioTotal}\nSalario excedente: R${extra}");
            Console.Write("\n\n*********************\n");
            Console.ReadKey();
        }
    }
}