using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.FileReceiver
{
    public interface IFile
    {
        int Order { get; set; }
        Task<string> GetFile();
    }
}
