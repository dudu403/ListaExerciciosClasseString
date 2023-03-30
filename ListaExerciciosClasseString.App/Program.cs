namespace ListaExerciciosClasseString.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma frase: ");
            string frase = Console.ReadLine();

            string fraseComTitulo = frase.ToTitleCase();
        }
    }
}