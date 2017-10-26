using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestHelloWorld.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            HelloWorld hello = new HelloWorld();
            Assert.AreEqual(hello.Name, "Hello LCG Team");
        }
    }
}
