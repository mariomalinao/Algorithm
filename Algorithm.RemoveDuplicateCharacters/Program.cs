namespace Algorithm.RemoveDuplicateCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter word: ");
            var word = Console.ReadLine();

            var processor = new Processor(word);
            Console.WriteLine(processor.Run());
        }
    }
}