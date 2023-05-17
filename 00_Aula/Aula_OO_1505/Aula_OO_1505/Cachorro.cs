namespace Aula_OO_1505 {
    internal class Cachorro : Animal {
        public Cachorro(string nome, int idade) : base(nome, idade) {
        }

        public override void emitirSom() {
            throw new NotImplementedException();
        }
    }
}
