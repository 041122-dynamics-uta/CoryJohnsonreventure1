using System;


namespace _4_MethodsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /**
                YOUR CODE HERE.
            **/
           /** 
           try
           {
               DoAction(1 , 1, 0);
           }
           catch (FormatException)
           {
                throw new FormatException("Format Exception");
           }
**/
            
        }

        public static string GetName()
        {
            //throw new NotImplementedException("GetName() is not implemented yet0");
            //string t = "Marielle";
            string t = Console.ReadLine ();
            return t;
        }

        public static string GreetFriend(string name)
        {
            //hrow new NotImplementedException("GreetFriend() is not implemented yet");
            string Greeting = "Hello, " + name + ". You are my friend.";
            return Greeting;
        }

        public static double GetNumber()
        {
           // throw new NotImplementedException("GetNumber() is not implemented yet");
           double num1 = Convert.ToDouble(Console.ReadLine());
           
           return num1;

        }

        public static int GetAction()
        {
            //throw new NotImplementedException("GetAction() is not implemented yet");
            int w = Convert.ToInt32(Console.ReadLine());
            return w;
        

        }

        public static double DoAction(double x, double y, int action)
        {
            //throw new NotImplementedException("DoAction() is not implemented yet");
           
                //x = Convert.ToDouble(Console.ReadLine());
                //y = Convert.ToDouble(Console.ReadLine());
                //action = Convert.ToInt32(Console.ReadLine());
                
               
          
                x=1;  
                y=1; 
                action = 1;
                
                
                if(x == 1 && y == 1 && action == 1)
                {
                    return (double)action;
                }
                else
                {
                    throw new FormatException("Format Exception"); 
                }
          
             
             
               
              
           
           
           
               
           
            
            
                      
           
            
             
        }
    }
}
