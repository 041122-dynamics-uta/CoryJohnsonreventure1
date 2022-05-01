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
            string day = "", month = "";
            if (year >= 1919)
            {
                int noOfDays = 0;
                bool bValue = true;
                for (int i = 1, j = 2; bValue; i++, j++)
                {

                    noOfDays += DateTime.DaysInMonth(year, i);

                    if ((256 - noOfDays) < DateTime.DaysInMonth(year, j))
                    {
                        bValue = false;
                        day = (256 - noOfDays).ToString();
                        month = j.ToString("00");
                    }
                }

            }
            else if (year < 1918)
            {
               
                
                    bool isLeapYear = false;
                    if (year % 4 == 0)
                    {
                        isLeapYear = true;
                    }
                    int noOfDays = 0;
                    bool bValue = true;
                    for (int i = 1, j = 2; bValue; i++, j++)
                    {
                        if (i != 2)
                            noOfDays += DateTime.DaysInMonth(year, i);
                        else
                        {
                            if (isLeapYear)
                            {
                                noOfDays += 29;
                            }
                            else
                            {
                                noOfDays += 28;
                            }
                        }

                        if ((256 - noOfDays) < DateTime.DaysInMonth(year, j))
                        {
                            bValue = false;
                            day = (256 - noOfDays).ToString();
                            month = j.ToString("00");
                        }
                    }
                
            }
            else
            {
                    int noOfDays = 0;
                    bool bValue = true;
                    for (int i = 1,j=2;bValue ;i++,j++)
                    {
                        if (i != 2)
                            noOfDays += DateTime.DaysInMonth(year, i);
                        else
                        {
                            noOfDays += 15;
                        }         
                        if ((256 - noOfDays) < DateTime.DaysInMonth(year, j))
                        {
                            bValue = false;
                            day = (256 - noOfDays).ToString("00");
                            month = j.ToString("00");
                        }
                    }
            }
            return day + "." + month + "." + year;
                    

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
}                                                                                        }                                                                                                                                                                                            