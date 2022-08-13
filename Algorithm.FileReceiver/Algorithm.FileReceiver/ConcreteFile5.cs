using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.FileReceiver
{
    public class ConcreteFile5 : IFile
    {
        public int Order { get; set; } = 5;

        public async Task<string> GetFile()
        {
            Thread.Sleep(0);
            return this.GetType().Name;
        }
    }
}