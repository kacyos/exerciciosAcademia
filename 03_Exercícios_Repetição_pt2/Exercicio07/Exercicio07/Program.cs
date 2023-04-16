namespace Exercicio07 {
    internal class Program {
        static void Main(string[] args) {

            while (true) {

                Console.Write("Digite seu nome: ");
                string nome = Console.ReadLine();
                int idade;
                double salario;
                
                if (!nome.All(char.IsLetter) || string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome)) {

                    Console.WriteLine("Nome inválido!");
                    break;
                } else {
                    Console.Write("Digite sua idade: ");
                    idade = int.Parse(Console.ReadLine());
                }

                if (idade <= 0) {
                    Console.WriteLine("Idade inválida!");
                    break;
                } else {
                    Console.Write("Digite seu salário: ");
                    salario = double.Parse(Console.ReadLine());
                }

                if (salario <= 0) {
                    Console.WriteLine("Salário inválido!");
                    break;
                } else {
                    Console.WriteLine($"\n\nNome: {nome}\nIdade: {idade}\nSalário: {salario.ToString("N2")}");
                    Console.WriteLine("\n\n");
                }
            }



        }
    }
}