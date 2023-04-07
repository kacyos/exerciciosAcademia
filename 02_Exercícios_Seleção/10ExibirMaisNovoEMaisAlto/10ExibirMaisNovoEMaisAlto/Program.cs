namespace _10ExibirMaisNovoEMaisAlto {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe o nome do(a) 1º atleta: ");
            string atleta01 = Console.ReadLine();

            Console.Write("Informe a idade do(a) 1º atleta: ");
            short idade01 = short.Parse(Console.ReadLine());

            Console.Write("Informe a altura do(a) 1º atleta: ");
            double altura01 = double.Parse(Console.ReadLine());

            Console.Write("Informe o nome do(a) 2º atleta: ");
            string atleta02 = Console.ReadLine();

            Console.Write("Informe a idade do(a) 2º atleta: ");
            short idade02 = short.Parse(Console.ReadLine());

            Console.Write("Informe a altura do(a) 2º atleta: ");
            double altura02 = double.Parse(Console.ReadLine());

            if ((altura01 > altura02) && (idade01 < idade02)) {
                Console.WriteLine($"\nNome: {atleta01}\nIdade: {idade01}\nAltura:{altura01}");
            }

            if ((altura02 > altura01) && (idade02 < idade01)) {
                Console.WriteLine($"\nNome: {atleta02}\nIdade: {idade02}\nAltura:{altura02}");
            }

        }
    }
}