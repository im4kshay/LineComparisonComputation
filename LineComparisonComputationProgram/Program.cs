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
            Console.WriteLine("Welcome to Line Comparison Computation program on Master Branch");
            LineComparison firstLine = new LineComparison();
            LineComparison secondLine = new LineComparison();
            firstLine.PointValues();
            double firstLineLength = firstLine.GetLength();
            Console.WriteLine("Length of first Line: " + firstLineLength);
            secondLine.PointValues();
            double secondLineLength = secondLine.GetLength();
            Console.WriteLine("Length of Second Line: " + secondLineLength);
            int status = LengthComparison(firstLineLength, secondLineLength);
            if (status > 0)
            {
                Console.WriteLine("Length Of First Line is greater ");
            }
            else if (status < 0)
            {
                Console.WriteLine("Length Of Second Line is greater");
            }
            else
            {
                Console.WriteLine("Length of both Lines are Equal");
            }
        }
        public static int LengthComparison(double firstLength, double secondLength)
        {
            return firstLength.CompareTo(secondLength);
        }
    }
}
