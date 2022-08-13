namespace Algorithm.Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter word: ");
            var word = Console.ReadLine();

            var processor = new Processor();
            var result = processor.Run(word);

            Console.WriteLine(result);
        }
    }
}