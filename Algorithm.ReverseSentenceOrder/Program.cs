namespace Algorithm.ReverseSentenceOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your sentence: ");
            var sentence = Console.ReadLine();

            var processor = new Processor();
            var result = processor.Run(sentence);

            Console.WriteLine(result);
        }
    }
}