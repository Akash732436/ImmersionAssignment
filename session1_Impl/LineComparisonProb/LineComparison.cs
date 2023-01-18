using session1_Impl.LineComparisonProb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session1_Impl
{
    public class LineComparison : ILineComparison
    {
        public LineComparison()
        {
            Console.WriteLine("Welcome to Line Comparison Computation");
            Console.WriteLine("1 for calulating length");
            Console.WriteLine("2 for checking if two lines are equal");
            Console.WriteLine("3 for comparing two lines");
        }

        public Double LengthOfLine()
        {

            //variables
            double x1,x2,y1,y2;

            //user input
            Console.WriteLine("Enter both the coordinates of the line (x,y)");
            x1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());

            double valLine=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));

            //Console.WriteLine("Length of the line is "+valLine);
            return valLine;

        }

        public bool CheckIfEqual()
        {
            Console.Write("For First Line ");
            Double Dist1 = LengthOfLine();
            Console.Write("For Second Line ");
            Double Dist2 = LengthOfLine();

            if(Dist1 == Dist2)
            {
                return true;
            }
            return false;
            

        }

        public int CompareLines()
        {
            Console.Write("For First Line");
            Double Dist1 = LengthOfLine();
            Console.Write("For Second Line");
            Double Dist2 = LengthOfLine();
            if(Dist1 == Dist2)
            {
                return 0;
            }
            if(Dist1>Dist2) { return 1; }
            return -1;

        }

    }
}
