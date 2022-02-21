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
            Console.WriteLine("Enter your mood :");

            string message = Console.ReadLine();

            MoodAnalyzer mood = new MoodAnalyzer(message);
            mood.AnalyzeMood();

        }
    }
}
