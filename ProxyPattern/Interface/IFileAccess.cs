using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Interface
{
    internal interface IFileAccess
    {
        void ReadFile(string fileName);
    }
}
