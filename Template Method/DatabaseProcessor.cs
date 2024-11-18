using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    internal class DatabaseProcessor : DataProcessor
    {
        protected override void LoadData()
        {
            Console.WriteLine("Loading data from the database...");
        }

        protected override void Process()
        {
            Console.WriteLine("Processing database data...");
        }

        protected override void SaveData()
        {
            Console.WriteLine("Saving processed database data...");
        }
    }
}
