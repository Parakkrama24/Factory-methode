using ProxyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal class FileAccessProxy:IFileAccess
    {
        private FileAccess _realFileAccess;
        private string _userRole;

        public FileAccessProxy(string userRole)
        {
            _userRole = userRole;
            _realFileAccess = new FileAccess();
        }

        public void ReadFile(string fileName)
        {
            if (_userRole == "Admin")
            {
                _realFileAccess.ReadFile(fileName);
            }
            else
            {
                Console.WriteLine("Access Denied: You do not have permission to read this file.");
            }
        }
    }
}
