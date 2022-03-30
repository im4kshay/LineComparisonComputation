using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonComputationProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");

            LineComparison lineComparison = new LineComparison();
            lineComparison.PointValues();
            double lineLength = lineComparison.GetLength();
            Console.WriteLine("Length of first Line according to points is= " + lineLength);
            Console.ReadLine();
        }
    }
}
