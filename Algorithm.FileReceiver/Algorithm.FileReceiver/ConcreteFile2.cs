using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.FileReceiver
{
    public class ConcreteFile2 : IFile
    {
        public int Order { get; set; } = 2;

        public async Task<string> GetFile()
        {
            Thread.Sleep(10000);
            return this.GetType().Name;
        }
    }
}