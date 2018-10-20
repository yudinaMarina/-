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
            string line = "Привет";
            string expected = "true";
            string actual = Program.Opred_Cyr(line);
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string line = "gfghhkyk";
            string expected = "false";
            string actual = Program.Opred_Cyr(line);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string line = "Привет hjfj";
            string expected = "true";
            string actual = Program.Opred_Cyr(line);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            string line = "gfghhkyk попророп";
            string expected = "false";
            string actual = Program.Opred_Cyr(line);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            string line = "12312343155";
            string expected = "false";
            string actual = Program.Opred_Cyr(line);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            string line = "!./,@";
            string expected = "false";
            string actual = Program.Opred_Cyr(line);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod7()
        {
            string line = "";
            string expected = "false";
            string actual = Program.Opred_Cyr(line);
            Assert.AreEqual(expected, actual);
        }
    }
}
