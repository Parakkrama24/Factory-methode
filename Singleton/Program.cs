using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Attempt to get multiple instances
            Logger logger1 = Logger.GetInstance();
            Logger logger2 = Logger.GetInstance();

            // Verify that both references point to the same instance
            Console.WriteLine(object.ReferenceEquals(logger1, logger2)); // True

            // Use the logger
            logger1.Log("Application started.");
            logger2.Log("Singleton pattern example.");


            Console.ReadKey();
        }
    }
}
