using FindMaxProblem;
using System;

namespace FindMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 110, 555, 423, 265, 890, 945 };
            FindMax<int> max = new FindMax<int>(arr);
            int actual = max.PrintMaxValue();
            Console.WriteLine(actual);
            float[] arr1 = { 77.9f, 18.5f, 3.3f, 89.36f, 56.23f, 20.6f };
            FindMax<float> max1 = new FindMax<float>(arr1);
            float actual1 = max1.PrintMaxValue();
            Console.WriteLine(actual1);
            string[] arr2 = { "python", "cpp", "java", "javascript", "corejava" };
            FindMax<string> max3 = new FindMax<string>(arr2);
            string actual2 = max3.PrintMaxValue();
            Console.WriteLine(actual2);
        }
    }
}
