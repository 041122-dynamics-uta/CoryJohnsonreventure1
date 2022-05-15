using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using P1StoreBusiness;
using P1StoreDomain;
using P1Repository;

namespace P1FrontEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            //String username = Console.ReadLine();
            //String secretcode = Console.ReadLine();
            
            MainMenu();
        }

        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to P1 Clearance Store");
            Console.WriteLine("1) Already a CSuromer: Login in");
            Console.WriteLine("2) Sign Up for New Account");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");
 
            switch (Console.ReadLine())
            {
                case "1":
                   Login();
                    break;
                case "2":
                    RegisterAccount();
                    break;
                case "3":
                    System.Environment.Exit(1);
                    break;
                default:
                    break;
               
            }   
        }

        //Login method
        public static void Login()
        {
            //Console.WriteLine("secretcode Masking Console Application");
            Console.WriteLine("------------------------------------");
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            string secretcode = Console.ReadLine();
            Console.Write("Enter Password: ");
            ConsoleKeyInfo keyInfo;
 
            do
            {
                keyInfo = Console.ReadKey(true);
                // Skip if Backspace or Enter is Pressed
                if (keyInfo.Key != ConsoleKey.Backspace && keyInfo.Key != ConsoleKey.Enter)
                    {
                        secretcode += keyInfo.KeyChar;
                        Console.Write("*");
                    }
                else
                    {
                        if (keyInfo.Key == ConsoleKey.Backspace && secretcode.Length > 0)
                        {
                            // Remove last charcter if Backspace is Pressed
                            secretcode = secretcode.Substring(0, (secretcode.Length - 1));
                            Console.Write("b b");
                        }
                    }             
            }
            // Stops Getting secretcode Once Enter is Pressed
            while (keyInfo.Key != ConsoleKey.Enter);
            Console.WriteLine("Welcome " + username +",");
            StoreOptions();
            return;
            //Console.WriteLine();
            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Welcome " + username+",");
            //Console.WriteLine("Your secretcode is : " + secretcode);
        }    

        //Register new Customer Account
        public static void RegisterAccount()
        {
            Console.Write("Enter username: ");
            Console.Write("Enter password: ");
            Console.Write("Renter password: ");
            Console.Write("Enter First name: ");
            Console.Write("Enter Last Name: ");
            Console.Write("Enter Address: ");

            string username = Console.ReadLine();
            string secretcode = Console.ReadLine();
            string fname = Console.ReadLine();
            string lname = Console.ReadLine();
            string address = Console.ReadLine();

            SqlCommand sqlComm = new SqlCommand();

          sqlComm.CommandText = $" INSERT INTO P1StoreCustomer (Username, LastNanme, FirstName, Address, secretcode)  VALUES (@var)";
          //sqlComm.AddWithValue("@var", username, lname,fname, address, secretcode);

        }

        //Displays the Customer info
        public static void ShowCustomerInfo()
        {
            string username = Console.ReadLine();
            string secretcode = Console.ReadLine();
            string fname = Console.ReadLine();
            string lname = Console.ReadLine();
            string address = Console.ReadLine();

            SqlCommand sqlComm = new SqlCommand();

          sqlComm.CommandText = $" INSERT INTO P1StoreCustomer (Username, LastNanme, FirstName, Address, secretcode)  VALUES (@var)";
          //sqlComm.AddWithValue("@var", username, lname,fname, address, secretcode);
            
            Console.Write(username);
            Console.Write(lname);
            //Console.Write("Renter password: ");
            Console.Write(" First name: " + fname);
            Console.Write("Last Name: " + lname);
            Console.Write("Address: " + address);
            StoreOptions();
        }

        //Select Store and Find items Logic
        public static void StoreOptions()
        {
            //Console.Clear();
            Console.WriteLine("P1 Clearance Store Menu");
             Console.WriteLine("Make a Selection");
            Console.WriteLine("1) Add to Cart");
            Console.WriteLine("2) Remove From cart");
            Console.WriteLine("3) View Cart");
            Console.WriteLine("4) View Products");
            Console.WriteLine("5) Checkout");
            Console.WriteLine("6) Back To Customer Account Info");
            Console.WriteLine("7) Exit");
            Console.Write("\r\nSelect an option: ");
 
            switch (Console.ReadLine())
            {
                case "1":
                   Login();
                    break;
                case "2":
                    RegisterAccount();
                    break;
                case "3":
                    System.Environment.Exit(1);
                    break;
                    case "4":
                   Login();
                    break;
                case "5":
                    RegisterAccount();
                    break;
                case "6":
                    Checkout();
                    break;
                case "7":
                    System.Environment.Exit(1);
                    break;
                default:
                    break;
               
            }   
        }

        //View Products from store
        public static void ViewCart()
        {
            Console.Clear();
            Console.WriteLine("Welcome to P1 Clearance Store");
            Console.WriteLine("1) Continue Shopping");
            Console.WriteLine("2) Back To Customer Account Info");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");
 
            switch (Console.ReadLine())
            {
                case "1":
                   SelectStore();
                    break;
                case "2":
                    StoreOptions();
                    break;
                case "3":
                    System.Environment.Exit(1);
                    break;
                default:
                    break;
               
            } 
        }
        
       //Shop logic 
        public static void SelectStore()
        {
            Console.Clear();
            Console.WriteLine("Welcome to P1 Clearance Store");
            Console.WriteLine("Select Store");
            Console.WriteLine("1) Store 1");
            Console.WriteLine("2) Store 2");
            Console.WriteLine("3) Store 3");
            Console.WriteLine("4) Back To Customer Account Info");
            Console.WriteLine("5) Exit");
             SqlCommand sqlComm = new SqlCommand();
 
            switch (Console.ReadLine())
            {
                case "1":
                   //Store 1;
                   sqlComm.CommandText = $"SELECT * FROM P1StoreDatabase.store1";
                    break;
                case "2":
                    //Store 2;
                     sqlComm.CommandText = $"SELECT * FROM P1StoreDatabase.store2";
                    break;
                case "3":
                    //Store3;
                     sqlComm.CommandText = $"SELECT * FROM P1StoreDatabase.store3";
                    break;
                 case "4":
                    StoreOptions();
                    break;
                case "5":
                     System.Environment.Exit(1);
                    break;
                default:
                    break;
                    
               
            } 
        } 

        public static void ShowProducts()
        {
            //show products
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.CommandText = $"SELECT * FROM P1StoreProducts";
        }
        
        //Make and cancel purchases
        public static void Checkout()
        {
              int order = 0;
              string ItemsOrdered = "";
                float OrderTotal = 0.00f;  
            //Console.Clear();
            Console.WriteLine("Welcome to P1 Clearance Store");
            Console.WriteLine(" Are you sure Sure?");
            Console.WriteLine("1) YES");
            Console.WriteLine("2) NO");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");
 
            switch (Console.ReadLine())
            {
                case "1":
                     ItemsOrdered = "";
                 OrderTotal = 0.00f; 
                    order= order + 1;
                   SqlCommand sqlComm = new SqlCommand();

          sqlComm.CommandText = $"INSERT INTO P1StoreOders (ItemsOrdered, OrderTotal ) VALUES (@var)";
          //sqlComm.AddWithValue("@var", ItemsOrdered, OrderTotal);
                    StoreOptions();
                    break;
                case "2":
                    StoreOptions();;
                    break;
                case "3":
                    System.Environment.Exit(1);
                    break;
                default:
                    break;
            
            }
        }



    
    }

}
