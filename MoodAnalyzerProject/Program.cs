using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string message1 = "I am in Sad mood";
            MoodAnalyzer mood1 = new MoodAnalyzer(message1);
            mood1.AnalyzeMood();

            string message2 = "I am in any mood";
            MoodAnalyzer mood2 = new MoodAnalyzer(message2);
            mood2.AnalyzeMood();
        }
    }
}
