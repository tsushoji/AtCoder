using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using (TARGETPROGRAMNAMESPACE);

namespace (TESTPROJECTNAMESPACE)
{
    [TestClass()]
    public class ProgramTests
    {
(TESTCASES)     
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