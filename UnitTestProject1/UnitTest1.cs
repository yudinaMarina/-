using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string line = "Привет мой друг";
            bool expected = true;
            bool actual = Program.Opred_Cyr(line);
            Assert.AreEqual(expected,actual);
        }

    }
}
