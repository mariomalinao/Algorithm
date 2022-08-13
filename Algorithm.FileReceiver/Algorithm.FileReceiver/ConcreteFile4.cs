using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.FileReceiver
{
    public class ConcreteFile4 : IFile
    {
        public int Order { get; set; } = 4;

        public async Task<string> GetFile()
        {
            Thread.Sleep(5000);
            return this.GetType().Name;
        }
    }
}