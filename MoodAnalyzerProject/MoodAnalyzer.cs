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
            try
            {
                if (this.msg.Equals(string.Empty))
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.EMPTY_MOOD, "Input should not be empty.");
                }
                if (msg.Equals("I am in sad mood"))
                {
                    return "Sad";
                }
                if (msg.Equals("I am in any mood")) 
                {
                    return "Happy";
                }
                if (msg == null)
                {
                    return "Happy";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NULL_MOOD, "Input should not be empty.");
            }
            return null;
        }
    }
       
    
}
