using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using ABC081A;

namespace ABC081ATest
{
    [TestClass()]
    public class UnitTest1
    {

        [TestMethod()]
        [Timeout(2000)]
        public void Test1()
        {
            string input = "101\n";
            string output = "2";

            AssertIO(input, output);
        }

        [TestMethod()]
        [Timeout(2000)]
        public void Test2()
        {
            string input = "000\n";
            string output = "0";

            AssertIO(input, output);
        }

        [TestMethod()]
        [Timeout(2000)]
        public void Test3()
        {
            string input = "101\n";
            string output = "2";

            AssertIO(input, output);
        }

        [TestMethod()]
        [Timeout(2000)]
        public void Test4()
        {
            string input = "000\n";
            string output = "0";

            AssertIO(input, output);
        }

        private void AssertIO(string input, string output)
        {
            StringReader reader = new StringReader(input);
            Console.SetIn(reader);

            StringWriter writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main(new string[0]);

            Assert.AreEqual(output + Environment.NewLine, writer.ToString());
        }
    }
}