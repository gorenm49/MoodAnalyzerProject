using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProject;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string message = "I am in sad mood";
            MoodAnalyzer mood = new MoodAnalyzer(message);
            Assert.AreEqual("Sad", mood.AnalyzeMood());
        }
        [TestMethod]
        public void TestMethod2()
        {
            string message = "I am in any mood";
            MoodAnalyzer mood = new MoodAnalyzer(message);
            Assert.AreEqual("Happy", mood.AnalyzeMood());
        }

        [TestMethod]
        public void TestMethod3()
        {
            string message =null;
            MoodAnalyzer mood = new MoodAnalyzer(message);
            Assert.AreEqual("Happy", mood.AnalyzeMood());
        }
    }
}
