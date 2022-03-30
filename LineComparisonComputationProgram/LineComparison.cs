using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonComputationProgram
{
    class LineComparison
    {
        public double xAxisStart, yAxisStart, xAxisEnd, yAxisEnd;
        public void PointValues()
        {
            Console.WriteLine("Enter X Start");
            xAxisStart = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y Start");
            yAxisStart = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter X End");
            xAxisEnd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y End");
            yAxisEnd = Convert.ToDouble(Console.ReadLine());
        }

        public double GetLength()
        {
            double length = Math.Sqrt(Math.Pow((xAxisEnd - xAxisStart), 2) + Math.Pow((yAxisEnd - yAxisStart), 2));
            return length;
        }
    }
}
