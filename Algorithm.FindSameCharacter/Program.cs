namespace Algorithm.FindSameCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter word: ");
            var word = Console.ReadLine();

            var processor = new Processor();
            var result = processor.FindCharacterCount(word);
            var duplicates = processor.FindDuplicates(word);

            Console.WriteLine(duplicates);
            Console.WriteLine(result);
        }
    }
}