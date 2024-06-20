using System.Text;
using System.Net;
using System.Text.RegularExpressions;

namespace TestCaseSourceBuilderForAtcoder
{
    internal class Program
    {
        private static Encoding _encoding = Encoding.GetEncoding("utf-8");
        private static String _exeFolderPath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        public static void Main(string[] args)
        {
            // AtCoaderの問題URLパラメータ
            string targetURL = args[0].ToString();
            // テストコード出力パスパラメータ
            string outputPath = args[1].ToString();
            if (targetURL == string.Empty)
            {
                Console.WriteLine("AtCoaderの問題URLパラメータが渡されておりません。");
                return;
            }
            if (outputPath == string.Empty)
            {
                Console.WriteLine("テストコード出力パスパラメータが渡されておりません。");
                return;
            }

            //テストコード出力
            string testcases = GetTestCase(GetContext(targetURL.Trim(new char[] { '\r', '\n', ' ' })));
            using (StreamWriter sw = new StreamWriter(outputPath, false, _encoding))
            {
                sw.Write(testcases);
            }

            Console.WriteLine("成功 出力テストコードパス:" + outputPath);
        }

        private static string GetTestCase(string html)
        {
            var testCasesStr = File.ReadAllText(_exeFolderPath + @"\\Template\\UnitTest_001.cs", _encoding);
            var testCaseMethodStr = File.ReadAllText(_exeFolderPath + @"\\Template\\UnitTestMethod_001.cs", _encoding);

            string anchor = "(<pre class=\"prettyprint linenums\">|<pre>)(?<testcase>.*?)</pre>";
            Regex re = new Regex(anchor, RegexOptions.IgnoreCase | RegexOptions.Singleline);

            StringBuilder sb = new StringBuilder();
            int i = 1;
            for (Match m = re.Match(html); m.Success; m = m.NextMatch())
            {
                if (m.Groups["testcase"].Value.Contains("<var>")) continue;

                string testCaseInput = m.Groups["testcase"].Value; m = m.NextMatch();
                string testCaseOutput = m.Groups["testcase"].Value;

                testCaseInput = testCaseInput.TrimStart('\r').TrimStart('\n').Replace("\r", "").Replace("\n", "\\n");
                testCaseOutput = testCaseOutput.TrimStart('\r').TrimStart('\n').TrimEnd('\n').TrimEnd('\r').Replace("\r", "").Replace("\n", "\\n");

                sb.AppendLine(testCaseMethodStr.Replace("(TESTNUM)", (i++).ToString()).Replace("(TESTCASEINPUT)", testCaseInput).Replace("(TESTCASEOUTPUT)", testCaseOutput));
            }

            return testCasesStr.Replace("(TESTCASES)", sb.ToString());
        }

        private static string GetContext(string url)
        {
            WebClient wc = new WebClient();
            byte[] data = wc.DownloadData(url);
            Encoding enc = Encoding.GetEncoding("utf-8");
            string ret = enc.GetString(data);
            wc.Dispose();
            return ret;
        }
    }
}
