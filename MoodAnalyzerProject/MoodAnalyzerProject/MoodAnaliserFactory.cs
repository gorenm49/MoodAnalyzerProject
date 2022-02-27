using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyzerProject
{
    public class MoodAnaliserFactory
    {
        public static object CreateMoodAnaliser(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);


            try
            {
                if (result.Success)
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalysis = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalysis);
                }
                else
                {
                    
                    //throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.IMPROPER_CLASS_NAME, "No such a class");
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.IMPROPER_CONSTRUCTOR_NAME, "Constructor not available");
                }
            }
            catch (ArgumentNullException)
            {

                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.IMPROPER_CLASS_NAME, "No such a class");
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }











        //public static string AnaliserFactory()
        //{
        //    Type type = Type.GetType("MoodAnalyzer");

        //    Console.WriteLine("Constructor in MoodAnalizer class:");

        //    ConstructorInfo[] constructors = type.GetConstructors();
        //    foreach (ConstructorInfo constructor in constructors)
        //    {
        //        Console.WriteLine(constructor.ToString());
        //    }
        //    return null;
        //}  


    }
}
