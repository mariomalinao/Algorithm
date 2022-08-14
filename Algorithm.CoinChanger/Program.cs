namespace Algorithm.CoinChanger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter amount (decimal): ");
                var amount = double.Parse(Console.ReadLine());

                var processor = new Processor();
                Console.WriteLine(processor.Run(amount));
                Console.WriteLine("");
            }
        }
    }
}