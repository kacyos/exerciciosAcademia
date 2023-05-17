namespace ExercicioOO02 {
    internal class Program {
        static void Main(string[] args) {
            Computador comp1 = new Computador();
            Console.Write("Informe a marca do computador 01: ");
            comp1.marca = Console.ReadLine();
            Console.Write("Informe o modelo do computador 01: ");
            comp1.modelo = Console.ReadLine();
            Console.Write("Informe o tipo do computador 01: ");
            comp1.tipo = Console.ReadLine();
            Console.Write("Informe o preço do computador 01: R$ ");
            comp1.preco = double.Parse(Console.ReadLine());


            Computador comp2 = new Computador("Acer", "d25311", "NoteBook", 3500);

            comp1.mostrarComputador();
            comp2.mostrarComputador();
        }
    }
}