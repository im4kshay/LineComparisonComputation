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

            Console.WriteLine("Welcome to Line Comparison Computation program on Master Branch");
            LineComparison firstLine = new LineComparison();
            LineComparison secondLine = new LineComparison();
            firstLine.PointValues();
            double firstLineLength = firstLine.GetLength();
            Console.WriteLine("Length of first Line: " + firstLineLength);
            secondLine.PointValues();
            double secondLineLength = secondLine.GetLength();
            Console.WriteLine("Length of Second Line: " + secondLineLength);

            bool status = LengthComparison(firstLineLength, secondLineLength);
            if (status)
            {
                Console.WriteLine("Both the Line lengths are Equal");
            }
            else
            {
                Console.WriteLine("Line Lengths are not Equal");
            }
        }

        public static Boolean LengthComparison(double firstLength, double secondLength)
        {
            return firstLength.Equals(secondLength);
        }
    }
}
