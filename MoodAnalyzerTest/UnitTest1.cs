using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProject;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
        MoodAnalyzer mood = new MoodAnalyzer();

        [TestMethod]
        public void TestMethod1()
        {
            string message = "Happy";
            Assert.AreEqual("Happy", mood.AnalyzeMood(message));
        }
    }
}
