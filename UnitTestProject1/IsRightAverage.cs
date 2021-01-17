using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRater;

namespace UnitTestProject1
{
    [TestClass]
    public class IsRightAverage
    {
        [TestMethod]
        public void AverageTest()
        {
            float expected = 2.5f;
            float actual = Helpers.GetAverage(2, 3, 4);
            Assert.AreEqual(expected, actual);
        }
    }
}
