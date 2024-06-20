using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using ABC081B;

namespace ABC081BTest
{
    [TestClass()]
    public class UnitTest1
    {

        [TestMethod()]
        [Timeout(2000)]
        public void Test1()
        {
            string input = "3\n8 12 40\n";
            string output = "2";

            AssertIO(input, output);
        }

        [TestMethod()]
        [Timeout(2000)]
        public void Test2()
        {
            string input = "4\n5 6 8 10\n";
            string output = "0";

            AssertIO(input, output);
        }

        [TestMethod()]
        [Timeout(2000)]
        public void Test3()
        {
            string input = "6\n382253568 723152896 37802240 379425024 404894720 471526144\n";
            string output = "8";

            AssertIO(input, output);
        }

        [TestMethod()]
        [Timeout(2000)]
        public void Test4()
        {
            string input = "3\n8 12 40\n";
            string output = "2";

            AssertIO(input, output);
        }

        [TestMethod()]
        [Timeout(2000)]
        public void Test5()
        {
            string input = "4\n5 6 8 10\n";
            string output = "0";

            AssertIO(input, output);
        }

        [TestMethod()]
        [Timeout(2000)]
        public void Test6()
        {
            string input = "6\n382253568 723152896 37802240 379425024 404894720 471526144\n";
            string output = "8";

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