namespace Exercicio05.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase:");
            string frase = Console.ReadLine();

            // Imprime a frase em letras maiúsculas
            Console.WriteLine("Frase em letras maiúsculas: " + frase.ToUpper()); 

            // Imprime a frase em letras minúsculas
            Console.WriteLine("Frase em letras minúsculas: " + frase.ToLower());

            // Imprime a quantidade de caracteres da frase
            Console.WriteLine("Quantidade de caracteres: " + frase.Length);

            // Imprime a primeira palavra da frase
            string primeiraPalavra = frase.Split()[0];
            Console.WriteLine("Primeira palavra: " + primeiraPalavra);

            // Imprime a última palavra da frase
            string[] palavras = frase.Split();
            string ultimaPalavra = palavras[palavras.Length - 1];
            Console.WriteLine("Última palavra: " + ultimaPalavra);

        }
    }
}