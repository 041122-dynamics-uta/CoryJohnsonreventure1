using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
         var time = s;
        var amOrPm = time.Substring(8);
        var hourComponent = time.Substring(0, 2);
        var remainingTimeComponent = time.Substring(2, 6);
        if (amOrPm == "AM" && hourComponent == "12")
        {
            hourComponent = "00";
        }
        else if (amOrPm == "PM")
        {
            var numericHourComponent = int.Parse(hourComponent);
            if (numericHourComponent != 12)
            {
                hourComponent = Convert.ToString(12 + numericHourComponent);
            }
        }
        s = hourComponent + remainingTimeComponent;
        return s;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
