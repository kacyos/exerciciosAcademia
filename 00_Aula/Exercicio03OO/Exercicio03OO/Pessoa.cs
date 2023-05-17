namespace Exercicio03OO {
    internal class Pessoa {
        public string nome;
        public int idade;

        public Pessoa(string nome, int idade) {
            this.nome = nome;
            this.idade = idade;
            Console.WriteLine($"\nNome: {nome}\nIdade: {idade}\n");
        }

        public Pessoa(int idade) {
            this.idade = idade;
            Console.WriteLine($"\nIdade: {idade}");
        }
    }
}
