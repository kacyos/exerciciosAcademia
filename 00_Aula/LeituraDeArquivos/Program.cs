namespace LeituraDeArquivos {
    internal class Program {
        static void Main(string[] args) {
            List<Pessoa> listaPessoas = new List<Pessoa>();

            Persistencia.popularArquivoLista("E:\\Projetos\\C#\\Academia Athos\\00_Aula\\LeituraDeArquivos\\dados.dat", listaPessoas);
            // Persistencia.exibirLista(listaPessoas);

            string nome;
            string dataNascimento;
            Pessoa pessoa;
            for (int i = 0; i < 1; i++) {
                Console.Write("Nome: ");
                nome = Console.ReadLine();

                Console.Write("Data de Nascimento: ");
                dataNascimento = Console.ReadLine();
                pessoa = new Pessoa(nome, dataNascimento);

                if (listaPessoas.Contains(pessoa)) {
                    listaPessoas.Add(pessoa);
                    Persistencia.atualizarPessoaArquivo(pessoa, "E:\\Projetos\\C#\\Academia Athos\\00_Aula\\LeituraDeArquivos\\dados.dat");
                } else {
                    Console.WriteLine("Pessoa com email já na base de dados");
                }
            }

            //Persistencia.gravarListaArquivo(listaPessoas, "E:\\Projetos\\C#\\Academia Athos\\00_Aula\\LeituraDeArquivos\\dados.dat");
        }
    }
}