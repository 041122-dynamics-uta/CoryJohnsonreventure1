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
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds(List<int> arr)
    {
             List<int> birdTypeCounts = new List<int>{0,0,0,0,0};

            for (int i = 0; i < arr.Count; i++)
                birdTypeCounts[arr[i] - 1]=birdTypeCounts[arr[i] - 1] +1;

            int maxBirdTypeCount = birdTypeCounts[0];
            int maxBirdType = 1;

            for (int i = 1; i < birdTypeCounts.Count; i++)
            {
                if (birdTypeCounts[i] > maxBirdTypeCount)
                {
                    maxBirdTypeCount = birdTypeCounts[i];
                    maxBirdTypeCount = i + 1;
                }

                if (birdTypeCounts[i] == maxBirdTypeCount && i + 1 < maxBirdType)
                  maxBirdTypeCount = i + 1;
            }    
        

            return maxBirdTypeCount;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
