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
     * Complete the 'dayOfProgrammer' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER year as parameter.
     */

    public static string dayOfProgrammer(int year)
    {
         var programmerDate = ""; int d;
        if (year >= 1919)
          { 
              if (year % 400 == 0 || (year % 100 != 0 && year % 4 == 0)) 
              {
                d = 244;
            }  
          } 
        else if (year <= 1917)
        {
           if (year % 4 == 0) {
                d = 244;
           }
        }
        else
        {
            
            programmerDate = "26.09.1918";
        } 
        int r = 256 - d;
        String date = r + "." + 9 + "." + year;

         
        programmerDate = date;
        return programmerDate;
       
    } 
        

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int year = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.dayOfProgrammer(year);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
