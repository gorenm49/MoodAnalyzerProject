using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProject
{
    class MoodAnalysisException : Exception
    {
        public enum ExceptionType
        {
            NULL_MOOD,
            EMPTY_MOOD
        }

        public ExceptionType exceptionType;

        public MoodAnalysisException(ExceptionType type, string msg) : base(msg)
        {
            this.exceptionType = type;
        }
    }
}
