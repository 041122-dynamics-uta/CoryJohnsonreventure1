using System;
using System.IO;


public class SweetandSalty
{
    public static void Main()
{       int Salty = 0;
int Sweet = 0;
int SweetSalkty = 0; 
    //int n = 100;
Console.WriteLine("Type First Nimber");
 int a = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Type Second Number");
int b = Convert.ToInt16(Console.ReadLine());

//Get number of row user wants
 //Console.WriteLine("How many rows?");
 //int rows = Convert.ToInt16(Console.ReadLine());
    //int[] arr = Enumerable.Range(a, b).ToArray();
   for(int i = a; i <= b ; i++)                         
    {
          
          
               // Number divisible by 15(
                //       divisible by both 3 & 5),
                // print 'FizzBuzz' in place
                // of the number
                if (i % 15 == 0){Console.Write("Sweet'nSalty" + " ");
                    SweetSalkty++;}
            
 
                // Number divisible by 3,
                // print 'Fizz' in place
                // of the number
                else if (i % 3 == 0){Console.Write("Sweet" + " ");
                    Sweet++;}    
            
 
                // Number divisible by
                // 5, print 'Buzz'
                // in place of the number
                else if (i % 5 == 0){Console.Write("Salty" + " ");
                    Salty++;}                                          
                    
                
                // Print the numbers
                else
                    Console.Write(i);
          
              
            
    }
              
           
                        

             
                 
    
        Console.Write("");
        Console.WriteLine("You've gotten Sweet  " + Sweet + "  times.");
        Console.WriteLine("You've gotten Sweet " + Salty + "  times.");
        Console.WriteLine("You've gotten Sweet " + SweetSalkty + "  times.");
    

}

}