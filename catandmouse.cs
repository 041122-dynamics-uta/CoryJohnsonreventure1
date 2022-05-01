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

class Solution {

    // Complete the catAndMouse function below.
    static string catAndMouse(int x, int y, int z) {
           string output = "";
            if (x < y)
                {
                    if (y <= z)
                    {
                        //cat A cat B Mouse
                        output = "Cat B";
                    }
                    else
                    {
                        if (z > x)
                        {
                            //cat A Mouse cat B
                            if (z - x > y - z)
                                output = "Cat B";
                            else if (z - x < y - z)
                                output = "Cat A";
                            else
                                output = "Mouse C";
                        }
                        else
                        {
                            //mouse Cat A Cat B
                            output = "Cat A";
                        }

                    }

                }
                else if (x > y)
                {
                    if (x <= z)
                    {
                        //cat B cat A Mouse
                        output = "Cat A";
                    }
                    else
                    {
                        if (z > y)
                        {
                            //cat B Mouse cat A
                            if (x - z > z - y)
                                output = "Cat B";
                            else if (x - z < z - y)
                                output = "Cat A";
                            else
                                output = "Mouse C";
                        }
                        else
                        {
                            //mouse Cat B Cat A
                            output = "Cat B";
                        }

                    }
                }
                else
                {
                    //cat fight will let the mouse run-away.
                    output = "Mouse C";
                }

            return output;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++) {
            string[] xyz = Console.ReadLine().Split(' ');

            int x = Convert.ToInt32(xyz[0]);

            int y = Convert.ToInt32(xyz[1]);

            int z = Convert.ToInt32(xyz[2]);

            string result = catAndMouse(x, y, z);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
