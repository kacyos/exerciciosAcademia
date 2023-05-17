namespace Exercicio01OO {
    internal class Program {
        static void Main(string[] args) {
            Carro carro1 = new Carro();

            Console.Write("Digite a marca do carro 01: ");
            carro1.marca = Console.ReadLine();
            Console.Write("Digite o modelo do carro 01: ");
            carro1.modelo = Console.ReadLine();
            Console.Write("Digite o ano de fabricação do carro 01: ");
            carro1.anoFabricacao = int.Parse(Console.ReadLine());

            Carro carro2 = new Carro();

            Console.Write("Digite a marca do carro 02: ");
            carro2.marca = Console.ReadLine();
            Console.Write("Digite o modelo do carro 02: ");
            carro2.modelo = Console.ReadLine();
            Console.Write("Digite o ano de fabricação do carro 02: ");
            carro2.anoFabricacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Carro 01");
            carro1.exbirCarro();

            Console.WriteLine("Carro 02");
            carro1.exbirCarro();

        }
    }
}