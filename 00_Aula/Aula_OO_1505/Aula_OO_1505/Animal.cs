namespace Aula_OO_1505 {
    public abstract class Animal {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Animal(string nome, int idade) {
            Nome = nome;
            Idade = idade;
        }

        public abstract void emitirSom();
    }
}
