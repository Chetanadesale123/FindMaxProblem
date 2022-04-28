using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxProblem
{
    public class FindMax
    {
        public int FindMaxInteger(int first, int second, int third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("first is greater" + first);
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("first is greater" + first);
                return second;
            }
            else
            {
                Console.WriteLine("Third is greater");
                return third;
            }
        }
        public float FindMaxFloat(float first, float second, float third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("first is greater" + first);
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("first is greater" + first);
                return second;
            }
            else
            {
                Console.WriteLine("Third is greater");
                return third;
            }
        }
    }
}

