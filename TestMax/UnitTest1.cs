using FindMaxProblem;
using NUnit.Framework;

namespace TestMax
{
    public class Tests
    {
        [Test]
        public void GivenGenericInput_WhenTestMax_ShouldRerturnMaxNum()
        {
            FindMax<int> max = new FindMax<int>(3, 2, 1);
            int actual = max.FindMaximum();
            Assert.AreEqual(actual, 3);
            FindMax<float> max1 = new FindMax<float>(77.9f, 18.5f, 3.3f);
            float actual1 = max1.FindMaximum();
            Assert.AreEqual(actual1, 77.9f);
            FindMax<string> max2 = new FindMax<string>("python", "cpp", "java");
            string actual2 = max2.FindMaximum();
            Assert.AreEqual(actual2, "python");
        }
    }
}
