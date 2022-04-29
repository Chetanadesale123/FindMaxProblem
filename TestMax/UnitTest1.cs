using FindMaxProblem;
using NUnit.Framework;

namespace TestMax
{
    public class Tests
    {
        [Test]
        public void GivenGenericInput_WhenTestMax_ShouldRerturnMaxNum()
        {
            int[] arr = { 110, 555, 423, 265, 890, 945 };
            FindMax<int> max = new FindMax<int>(arr);
            int actual = max.PrintMaxValue();
            Assert.AreEqual(actual, 945); 
            float[] arr1 = { 77.9f, 18.5f, 3.3f, 89.36f,56.23f,20.6f };
            FindMax<float> max1 = new FindMax<float>(arr1);
            float actual1 = max1.PrintMaxValue();
            Assert.AreEqual(actual1,89.36f );
            string[] arr2 = { "python", "cpp", "java","javascript","corejava" };
            FindMax<string> max3 = new FindMax<string>(arr2);
            string actual2 = max3.PrintMaxValue();
            Assert.AreEqual(actual2, "python");
        }
    }
}
