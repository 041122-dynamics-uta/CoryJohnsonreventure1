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
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

    public static int sockMerchant(int n, List<int> ar)
    {
        int matchingPairsCount= 0 ; 
        int[] arr =new int[n];
        var ix=0;
        for (int i = 0 ; i< arr.Length ; i++)
        {
            int countPairs = 0 ;
            for(int j = 0 ;j< arr.Length ;j++)
            {
     
                if(ar[i] == ar[j] && i<j&& (!arr.Contains(i)|| i==0))
                {
                    arr[ix]=j;
                    ix++;
                    matchingPairsCount = matchingPairsCount + 1 ;
                    break;
                }
            }         

        }
        return  matchingPairsCount;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
