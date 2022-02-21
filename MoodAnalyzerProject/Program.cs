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
            MoodAnalyzer mood = new MoodAnalyzer();
            mood.AnalyzeMood("Happy");
        }
    }
}
