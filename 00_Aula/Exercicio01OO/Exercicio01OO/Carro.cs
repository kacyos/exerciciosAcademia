namespace Exercicio01OO {
    internal class Carro {
        public string marca;
        public string modelo;
        public int anoFabricacao;

        public void exbirCarro() {
            Console.WriteLine("*****************");
            Console.WriteLine($"Marca: {marca}\nModelo: {modelo}\nAno de Fabricação: {anoFabricacao}");
            Console.WriteLine("*****************");
        }

    }
}
