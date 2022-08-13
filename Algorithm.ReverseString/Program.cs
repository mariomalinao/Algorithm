namespace Algorithm.ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the word: ");
            var word = Console.ReadLine();

            var processor = new Processor();
            processor.Run(word);
        }
    }
}