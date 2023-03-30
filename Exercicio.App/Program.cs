namespace Exercicio.App

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"C:\Users\User\Documents.csv");
            string caminhoArquivo = Console.ReadLine();

            if (!File.Exists(caminhoArquivo))
            {
                Console.WriteLine("Arquivo não encontrado.");
                return;
            }

            string conteudo = File.ReadAllText(caminhoArquivo);

            Console.WriteLine("Total de cidades: " + ContarCidades(conteudo));
        }

        static int ContarCidades(string conteudo)
        {
            string[] linhas = conteudo.Split('\n');

            int numCidades = 0;
            for (int i = 0; i < linhas.Length; i++)
            {
                string[] campos = linhas[i].Split(',');
                if (campos.Length >= 2)
                {
                    numCidades++;
                }
            }

            return numCidades;
        }
    }
}