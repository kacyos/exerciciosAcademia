namespace Exercicio02 {
    internal class Program {
        static void Main(string[] args) {
            new Aluno("Aluno1", "123456");
            new Aluno(DateOnly.Parse("05/09/1987"));
            new Aluno("Aluno3", DateOnly.Parse("10/05/2023"), 1998);
        }
    }
}