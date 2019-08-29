using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using UnitTestProject2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ArithmaticClass arithmaticClass = new ArithmaticClass();

            int x = 10;
            int y = 20;

            int expectedResult = 30;
            int result = arithmaticClass.sumNumber(x, y);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            ArithmaticClass arithmaticClass = new ArithmaticClass();

            int x = 10;

            int result = arithmaticClass.randomFunction(x);

            Assert.AreEqual(9, result);
        }
    }
}
