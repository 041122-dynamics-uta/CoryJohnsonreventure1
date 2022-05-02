using System;

namespace _3_DataTypeAndVariablesChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //
            //
            // Insert code here.
            //
            //
            byte b = 255;
            bool IsValid = true;
            int a = 1;
            sbyte sb = 25;
            short t = 0;
            long l = -64;
            uint ui = 2;
            ushort ut = 0;
            ulong ul = 64;
            char c = 'a';
            float fl = 2.9f;
            double d = 1 * 10^-324;
            decimal dc = (decimal)(4.7 * Math.Pow(10 , 30));
            string name = "Cory";
            
            Console.WriteLine(PrintValues(b));
            Console.WriteLine(PrintValues(IsValid));
            Console.WriteLine(PrintValues(a));
            Console.WriteLine(PrintValues(sb));
            Console.WriteLine(PrintValues(t));
            Console.WriteLine(PrintValues(l));
            Console.WriteLine(PrintValues(ui));
            Console.WriteLine(PrintValues(c));
            Console.WriteLine(PrintValues(ut));
            Console.WriteLine(PrintValues(ul));
            Console.WriteLine(PrintValues(fl));
            Console.WriteLine(PrintValues(d));
            Console.WriteLine(PrintValues(dc));
            Console.WriteLine(PrintValues(name));
            


        }

        /// <summary>
        /// This method has an 'object' type parameter. 
        /// 1. Create a switch statement that evaluates for the data type of the parameter
        /// 2. You will need to get the data type of the parameter in the 'case' part of the switch statement
        /// 3. For each data type, return a string of exactly format, "Data type => <type>" 
        /// 4. For example, an 'int' data type will return ,"Data type => int",
        /// 5. A 'ulong' data type will return "Data type => ulong",
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string PrintValues(object obj)
        {
            //throw new NotImplementedException($"PrintValues() has not been implemented");
            Console.WriteLine(obj.GetType() + "is ThreadStaticAttribute string");

            string statement = "";
            switch(obj)
            {
                case byte b:
                statement = "Data type => byte";
                return statement;
                case bool IsValid :
                statement = "Data type => bool";
                return statement;
                case int a  :
                statement = "Data type => int";
                return statement;
                case sbyte sb:
                statement = "Data type => sbyte";
                return statement;
                case short t:
                statement = "Data type => short";
                return statement;
                case long l:
                statement = "Data type => long";
                return statement;
                case uint ui:
                statement = "Data type => uint";
                return statement;
                case ushort ut:
                statement = "Data type => ushort";
                return statement;
                case ulong ul:
                statement = "Data type => ulong";
                return statement;
                case char c:
                statement = "Data type => char";
                return statement;
                case float fl:
                statement = "Data type => float";
                return statement;
                case double d:
                statement = "Data type => double";
                return statement;
                case decimal dc:
                statement = "Data type => decimal";
                return statement;
                case string name:
                statement = "Data type => string";
                return statement;
                default:
                statement = null;
                break;
            }
            return "";

        }

        /// <summary>
        /// THis method has a string parameter.
        /// 1. Use the .TryParse() method of the Int32 class (Int32.TryParse()) to convert the string parameter to an integer. 
        /// 2. You'll need to investigate how .TryParse() and 'out' parameters work to implement the body of StringToInt().
        /// 3. If the string cannot be converted to a integer, return 'null'. 
        /// 4. Investigate how to use '?' to make non-nullable types nullable.
        /// </summary>
        /// <param name="numString"></param>
        /// <returns></returns>
        public static int? StringToInt(string numString)
        {
            //throw new NotImplementedException($"StringToInt() has not been implemented");
            int i;
            bool myBool= Int32.TryParse(numString, out i);
            if(myBool)
            {
                return i;
            }
            else
            {
                return null;
            }

        }
    }// end of class
}// End of Namespace
