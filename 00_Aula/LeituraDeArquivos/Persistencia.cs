
namespace LeituraDeArquivos {
    internal class Persistencia {

        public static void lerArquivo(string nomeArquivo) {
            try {

                StreamReader leitor = new StreamReader(nomeArquivo);
                do {
                    Console.WriteLine(leitor.ReadLine());
                } while (!leitor.EndOfStream);
                leitor.Close();

            } catch (Exception) {

                Console.WriteLine("Falha ao ler arquivo");
            }

        }

        public static void lerArquivoExibeNomes(string nomeArquivo) {

            try {

                StreamReader leitor = new StreamReader(nomeArquivo);

                string[] vetorLinha;
                string linha;

                do {
                    linha = leitor.ReadLine();
                    vetorLinha = linha.Split(";");
                    Console.WriteLine(vetorLinha[0]);
                } while (!leitor.EndOfStream);
                leitor.Close();

            } catch (Exception) {

                Console.WriteLine("Falha ao ler arquivo");
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nomeArquivo"></param>
        /// <param name="lista"></param>
        public static void popularArquivoLista(string nomeArquivo, List<Pessoa> lista) {

            try {

                StreamReader leitor = new StreamReader(nomeArquivo);

                string[] vetorLinha;
                string linha;

                do {
                    linha = leitor.ReadLine();
                    vetorLinha = linha.Split(";");
                    lista.Add(new Pessoa(vetorLinha[0], vetorLinha[1], vetorLinha[2]));
                } while (!leitor.EndOfStream);
                leitor.Close();

            } catch (Exception) {

                Console.WriteLine("Falha ao ler arquivo");
            }

        }

        public static void exibirLista(List<Pessoa> lista) {
            foreach (var pessoa in lista) {
                Console.WriteLine(pessoa);
            }
        }

        public static void gravarListaArquivo(List<Pessoa> lista, string nomeArquivo) {
            StreamWriter escritor = new StreamWriter(nomeArquivo);

            foreach (var item in lista) {
                escritor.WriteLine(item.Nome + ";" + item.Email + ";" + item.DataNascimento);
                escritor.Flush();
            }

            escritor.Close();
        }

        public static void atualizarPessoaArquivo(Pessoa pessoa, string nomeArquivo) {
            StreamWriter escritor = new StreamWriter(nomeArquivo, append: true);
            escritor.WriteLine(pessoa.Nome + ";" + pessoa.Email + ";" + pessoa.DataNascimento);
            escritor.Close();
        }
    }
}
