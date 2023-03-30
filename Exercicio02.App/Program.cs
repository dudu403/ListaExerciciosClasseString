using System.Reflection.Metadata.Ecma335;

namespace Exercicio02.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma frase: ");
            string frase = Console.ReadLine();

            int NumPalavras = ContarPalavras(frase);
            Console.WriteLine("A frase contém " + NumPalavras + " palavras.");
        }

        static int ContarPalavras(string frase)
        {
            int numPalavras = 0;
            bool estaEmPalavra = false;

            for (int i = 0; i < frase.Length; i++)
            {
                if (Char.IsWhiteSpace(frase[i]) || Char.IsPunctuation(frase[i]))
                {
                    estaEmPalavra = false;
                }
                else if (!estaEmPalavra)
                {
                    numPalavras++;
                    estaEmPalavra = true;
                }
            }

            return numPalavras;

        }


    }
}