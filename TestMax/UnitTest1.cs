using FindMaxProblem;
using NUnit.Framework;

namespace TestMax
{
    public class Tests
    {
        [Test]
        public void GivenIntMaxNumInPositionOne_WhenTestMax_ShouldRAETURNMaxNum()
        {
            FindMax max = new FindMax();
            int actual = max.FindMaxInteger(3, 2, 1);
            Assert.AreEqual(actual, 3);
        }
        [Test]
        public void GivenIntMaxNumInPositionTwo_WhenTestMax_ShouldRAETURNMaxNum()
        {
            FindMax max = new FindMax();
            int actual = max.FindMaxInteger(2, 3, 1);
            Assert.AreEqual(actual, 3);
        }
        [Test]
        public void GivenIntMaxNumInPositionThree_WhenTestMax_ShouldRAETURNMaxNum()
        {
            FindMax max = new FindMax();
            int actual = max.FindMaxInteger(1, 2, 3);
            Assert.AreEqual(actual, 3);
        }
        [Test]
        public void GivenfloatMaxNumInPositionOne_WhenTestMax_ShouldRAETURNMaxNum()
        {
            FindMax max = new FindMax();
            float actual = max.FindMaxFloat(77.9f,18.5f, 3.3f);
            Assert.AreEqual(actual,77.9f);
        }
        [Test]
        public void GivenfoatMaxNumInPositionTwo_WhenTestMax_ShouldRAETURNMaxNum()
        {
            FindMax max = new FindMax();
            float actual = max.FindMaxFloat(18.5f,77.9f,3.3f);
            Assert.AreEqual(actual, 77.9f);
        }
        [Test]
        public void GivenfloatMaxNumInPositionThree_WhenTestMax_ShouldRAETURNMaxNum()
        {
            FindMax max = new FindMax();
            float actual = max.FindMaxFloat(3.3f,18.5f,77.9f);
            Assert.AreEqual(actual, 77.9f);
        }
        [Test]
        public void GivenStringMaxNumInPositionOne_WhenTestMax_ShouldRAETURNMaxNum()
        {
            FindMax max = new FindMax();
            string actual = max.FindMaxString("python","cpp","java");
            Assert.AreEqual(actual,"python");
        }
        [Test]
        public void GivenStringMaxNumInPositionTwo_WhenTestMax_ShouldRAETURNMaxNum()
        {
            FindMax max = new FindMax();
            string actual = max.FindMaxString("cpp","python","java");
            Assert.AreEqual(actual,"python");
        }
        [Test]
        public void GivenStringMaxNumInPositionThree_WhenTestMax_ShouldRAETURNMaxNum()
        {
            FindMax max = new FindMax();
            string actual = max.FindMaxString("java","cpp","python");
            Assert.AreEqual(actual, "python");
        }
    }
}
