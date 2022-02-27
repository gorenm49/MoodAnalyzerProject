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
            string message ="";
            MoodAnalyzer mood = new MoodAnalyzer(message);
            Assert.AreEqual("Input should not be empty.", mood.AnalyzeMood());
        }

        [TestMethod]
        public void TestMethod4()
        {
            string message = null;
            MoodAnalyzer mood = new MoodAnalyzer(message);
            Assert.AreEqual("Input should not be null.", mood.AnalyzeMood());
        }

        [TestMethod]
        public void ClassNameShouldReturnObject()
        {
            //string message = null;
            object expected = new MoodAnalyzer();
            object obj = MoodAnaliserFactory.CreateMoodAnaliser("MoodAnalyzerProject.MoodAnalyzer", "MoodAnalyzer");
            var objtype = obj.GetType();
            var expectedType = expected.GetType();
            Assert.AreEqual(expectedType, objtype);
        }

        [TestMethod]
        public void ImproperClassNameShouldThrowException()
        {
            //string message = null;
            object expected = "No such a class";
            object obj = MoodAnaliserFactory.CreateMoodAnaliser("MoodAnalyzerProject.MoodAnalysser", "MoodAnalyzer");
            //expected.Equals(obj);
            var objType = obj.GetType();
            Assert.AreEqual(expected,objType );
        }

        [TestMethod]
        public void ImproperConstructorNameShouldThrowException()
        {
            //string message = null;
            object expected = new MoodAnalyzer();
            object obj = MoodAnaliserFactory.CreateMoodAnaliser("MoodAnalyzerProject.MoodAnalyzer", "MoodAnalyser");
            expected.Equals(obj);
            Assert.AreEqual("Constructor not available", obj);
        }
    }
}

