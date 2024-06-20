using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using ABC087B;

namespace ABC087BTest
{
    [TestClass()]
    public class UnitTest1
    {

        [TestMethod()]
        //[Timeout(2000)]
        public void Test1()
        {
            string input = "2\n2\n2\n100\n";
            string output = "2";

            AssertIO(input, output);
        }

        [TestMethod()]
        //[Timeout(2000)]
        public void Test2()
        {
            string input = "5\n1\n0\n150\n";
            string output = "0";

            AssertIO(input, output);
        }

        [TestMethod()]
        //[Timeout(2000)]
        public void Test3()
        {
            string input = "30\n40\n50\n6000\n";
            string output = "213";

            AssertIO(input, output);
        }

        [TestMethod()]
        //[Timeout(2000)]
        public void Test4()
        {
            string input = "2\n2\n2\n100\n";
            string output = "2";

            AssertIO(input, output);
        }

        [TestMethod()]
        //[Timeout(2000)]
        public void Test5()
        {
            string input = "5\n1\n0\n150\n";
            string output = "0";

            AssertIO(input, output);
        }

        [TestMethod()]
        //[Timeout(2000)]
        public void Test6()
        {
            string input = "30\n40\n50\n6000\n";
            string output = "213";

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