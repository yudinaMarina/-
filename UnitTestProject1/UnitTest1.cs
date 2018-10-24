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
        [TestMethod]
        public void TestMethod2()
        {
            string line = "Привет gfhdfhhgfh";
            bool expected = false;
            bool actual = Program.Opred_Cyr(line);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string line = "Hi my friend";
            bool expected = false;
            bool actual = Program.Opred_Cyr(line);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            string line = "";
            bool expected = false;
            bool actual = Program.Opred_Cyr(line);
            Assert.AreEqual(expected, actual);
        }
    }
}
