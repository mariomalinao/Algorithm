using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.FileReceiver
{
    public class Processor
    {
        public async Task Run()
        {
            var fileProcessors = new List<IFile>() {
                new ConcreteFile1(),
                new ConcreteFile3(),
                new ConcreteFile2(),
                new ConcreteFile4(),
                new ConcreteFile5()
            };

            var stopwatch = Stopwatch.StartNew();

            Console.WriteLine($"{stopwatch.ElapsedMilliseconds} ms");
            var tasks = fileProcessors.Select(x => (x.Order, Task: x.GetFile()));

            Console.WriteLine($"{stopwatch.ElapsedMilliseconds} ms");
            foreach (var task in tasks.OrderBy(x => x.Order))
                Console.WriteLine(await task.Task);

            Console.WriteLine($"{stopwatch.ElapsedMilliseconds} ms");
            stopwatch.Stop();
        }
    }
}
