using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.FileReceiver
{
    public class ConcreteFile3 : IFile
    {
        public int Order { get; set; } = 3;

        public async Task<string> GetFile()
        {
            Thread.Sleep(0);
            return this.GetType().Name;
        }
    }
}