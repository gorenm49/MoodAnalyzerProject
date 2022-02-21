using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProject
{
    public class MoodAnalyzer
    {
        public string AnalyzeMood(string msg)
        {
            if (msg.Equals("Happy"))
            {
                return "Happy";
            }
            if(msg.Equals("Sad"))
            {
                return "Sad";
            }
            return null;
        }
    }
}
