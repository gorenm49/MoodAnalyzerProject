using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProject
{
    
    public class MoodAnalyzer
    {
        string msg;
        public MoodAnalyzer()
        {
        }
        public MoodAnalyzer(string msg)
        {
                this.msg = msg;
        }
        public string AnalyzeMood()
        {
            if (msg.Equals("I am in sad mood"))
            {
                return "Sad";
            }
            if (msg.Equals("I am in any mood"))
            {
                return "Happy";
            }
            return null;
        }
    }
}
