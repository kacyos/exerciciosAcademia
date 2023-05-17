namespace Exercicio_Heranca01 {
    internal class Aluno : Pessoa {
        public string matricula;

        public void Apresentar() {
            Console.WriteLine($"** Aluno **\nNone: {nome}\nIdade: {idade}\nMatrícula: {matricula}\n\n");
        }
    }
}
