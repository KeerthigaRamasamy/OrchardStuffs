using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using unit_test;

namespace test_calc
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int c;
            calc obj = new calc();
            c=obj.add(2, 3);
            Assert.AreEqual(5, c);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int c;
            calc obj = new calc();
            c = obj.mul(2, 3);
            Assert.AreEqual(6, c);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int c;
            calc obj = new calc();
            try
            {
                c = obj.div(3, 0);
            }
            catch (DivideByZeroException e)
            {
                Assert.AreEqual(e.GetType(), typeof( DivideByZeroException));              
            }          
        }
    }
}
