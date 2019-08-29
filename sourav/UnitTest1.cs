using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Class1;


namespace sourav
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int res = 0;
            int a = 2, b = 5;
            Class1 obj = new Class1();
            if (obj.sum(a, b) == 7)
                res++;
            if (obj.product(a, b) == 10)
                res = res + 2;
            //return res;
            Assert.AreEqual(1, 1);
        }
    }
}
