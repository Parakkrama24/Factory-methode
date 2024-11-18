using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Processing Text File:");
            DataProcessor textProcessor = new TextFileProcessor();
            textProcessor.ProcessData();

            Console.WriteLine("\nProcessing Database:");
            DataProcessor dbProcessor = new DatabaseProcessor();
            dbProcessor.ProcessData();

            Console.ReadKey();
        }
    }
}
