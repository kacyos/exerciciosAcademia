namespace Exercicio_Heranca01 {
    internal class Program {
        static void Main(string[] args) {
            Pessoa pessoa = new Pessoa();
            pessoa.nome = "Pessoa01";
            pessoa.idade = 35;
            pessoa.Apresentar();

            Aluno aluno = new Aluno();
            aluno.nome = "Caio";
            aluno.idade = 19;
            aluno.matricula = "25aa2145";
            aluno.Apresentar();

            Professor professor = new Professor();
            professor.nome = "Luiz";
            professor.idade = 40;
            professor.disciplina = "Matemática";
            professor.Apresentar();

        }
    }
}