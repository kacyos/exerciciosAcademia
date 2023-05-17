namespace Aula_OO_1505 {
    internal class Cavalo : Animal {
        public string Raca { get; set; }
        public Cavalo(string nome, int idade, string raca) : base(nome, idade) {
            Raca = raca;
        }

        public override void emitirSom() {
            Console.WriteLine($"O {this.Nome} está relinchando.");
        }
    }
}
