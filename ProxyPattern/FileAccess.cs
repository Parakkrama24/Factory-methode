using ProxyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal class FileAccess : IFileAccess
    {
        public void ReadFile(string fileName)
        {
            Console.WriteLine($"Reading file: {fileName}");
        }
    }
    
}
