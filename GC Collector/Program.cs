using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Collector
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            random.Name = "great";
            var generation = GC.GetGeneration(random);

            GC.Collect(generation);

            Console.ReadKey();
        }
    }
}
