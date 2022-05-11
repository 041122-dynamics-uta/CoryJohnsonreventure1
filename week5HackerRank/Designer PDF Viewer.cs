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
     * Complete the 'designerPdfViewer' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY h
     *  2. STRING word
     */

    public static int designerPdfViewer(List<int> h, string word)
    {
             List<char> alphabet = new List<char>(){'a','b','c','d','e','f','g','h','i',            'j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
      
            char[] wordChar = word.ToCharArray();
            int maxAlphabetHeight=0;
            var areaOfSelectedText =0;
            var   SizeofLetter=wordChar.Length;
      
            for( var i=0;i<wordChar.Length;i++)
            {
           
                var cIndex=alphabet.IndexOf(wordChar[i]);
            
                if(maxAlphabetHeight<h[cIndex]){
                maxAlphabetHeight=h[cIndex];
             
            }
         
        
          
          
         }
         areaOfSelectedText =SizeofLetter*maxAlphabetHeight;
         return areaOfSelectedText ;
      
      
      
     

    

            

    }

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<int> h = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(hTemp => Convert.ToInt32(hTemp)).ToList();

        string word = Console.ReadLine();

        int result = Result.designerPdfViewer(h, word);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
}