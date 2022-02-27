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
            INVALID_MOOD,
            EMPTY_MOOD,
            IMPROPER_CLASS_NAME,
            IMPROPER_CONSTRUCTOR_NAME
        }

        public ExceptionType exceptionType;

        public MoodAnalysisException(ExceptionType type, string msg) : base(msg)
        {
            this.exceptionType = type;
        }
    }
}
