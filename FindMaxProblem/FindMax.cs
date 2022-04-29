using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxProblem
{
    public class FindMax<T> where T : IComparable
    {
        public T[] value;
        public FindMax(T[] value)
        {
            this.value = value;

        }
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T MaxValue(params T[] values)
        {
            var SortedValues = Sort(values);
            return SortedValues[^1];

        }
        public T PrintMaxValue()
        {
            var max = MaxValue(this.value);
            return max;

        }


    }
}

