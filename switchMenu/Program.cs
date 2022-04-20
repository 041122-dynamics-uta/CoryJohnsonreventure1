using System;
using System.IO;
//using System.Console;

namespace switchMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Make your Selection,please");
            int Selection = 1;

            switch (Selection) 
            {
            case 1:
	    
	          Console.WriteLine("Dial 1");
            break;
            case 2:
   	 
          	Console.WriteLine("Dial 2");
            break;
            case 3:
    	
	            Console.WriteLine("Dial 3");
              break;
            }

        }
    }
}
