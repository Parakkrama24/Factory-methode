using ProxyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Admin user accessing the file
            IFileAccess adminAccess = new FileAccessProxy("Admin");
            adminAccess.ReadFile("admin_report.txt");

            // Non-admin user attempting to access the file
            IFileAccess userAccess = new FileAccessProxy("User");
            userAccess.ReadFile("user_report.txt");

            Console.ReadKey();
        }
    }
}
