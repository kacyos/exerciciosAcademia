namespace ExercicioOO02 {
    internal class Computador {
        public double? preco;
        public string marca;
        public string modelo;
        public string tipo;

        public Computador() {
        }

        public Computador(string marca, string modelo, string tipo, double preco) {
            this.marca = marca;
            this.modelo = modelo;
            this.tipo = tipo;
            this.preco = preco;
        }

        public void mostrarComputador() {
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            Console.Write($"Marca: {marca}\nModelo: {modelo}\nTipo: {tipo}\nPreço: R${preco.Value.ToString("N2")}\n");
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
        }
    }
}