namespace Exercicio10 {
    internal class Program {
        static void Main(string[] args) {
            int m = 0;
            int f = 0;
            int IdadeInferioA30 = 0;
            int IdadeSuperiorA60 = 0;
            int somaIdadeFeminina = 0;

            for (int i = 0; i < 50; i++) {
                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o sexo: ");
                char sexo = char.Parse(Console.ReadLine().ToLower());

                Console.Write("Digite a idade: ");
                int idade = int.Parse(Console.ReadLine());

                if(idade < 30) {
                    IdadeInferioA30++;
                }

                if (idade > 60) {
                    IdadeSuperiorA60++;
                }

                switch (sexo) {
                    case 'm':
                        m++;
                        break;
                    case 'f':
                        Console.WriteLine('f');
                        f++;
                        somaIdadeFeminina += idade;
                        break;
                    default:
                        break;
                }

            }

            Console.WriteLine($"Número de pessoas do sexo masculino: {m}");
            Console.WriteLine($"Número de pessoas do sexo feminino: {f}");
            Console.WriteLine($"Número de pessoas com idade inferior a 30 anos: {IdadeInferioA30}");
            Console.WriteLine($"Número de pessoas com idade superior a 60 anos.: {IdadeSuperiorA60}");
            Console.WriteLine($"Média de idade das mulheres: {somaIdadeFeminina / f}");
        }
    }
}