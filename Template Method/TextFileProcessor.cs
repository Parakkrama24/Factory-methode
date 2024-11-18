using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    internal class TextFileProcessor : DataProcessor
    {
        protected override void LoadData()
        {
            Console.WriteLine("Loading data from text file...");
        }

        protected override void Process()
        {
            Console.WriteLine("Processing text file data...");
        }

        protected override void SaveData()
        {
            Console.WriteLine("Saving processed text file data...");
        }
    }
}
