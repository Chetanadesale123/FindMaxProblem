using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxProblem
{
    public class FindMax<T> where T : IComparable
    {
        public T first, second, third;
        public FindMax(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        public T FindMaximum()
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

