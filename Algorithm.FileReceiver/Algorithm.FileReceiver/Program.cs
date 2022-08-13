namespace Algorithm.FileReceiver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var processor = new Processor();
            processor.Run().Wait();
        }
    }
}