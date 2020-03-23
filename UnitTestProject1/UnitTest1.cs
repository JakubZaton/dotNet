using FizzBuzz_01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FizzBuzzTest()
        {
            var fb = new FizzBuzz();
            var result = fb.Iterate(1);
            Assert.AreEqual("1", result);
        }
    }
}
