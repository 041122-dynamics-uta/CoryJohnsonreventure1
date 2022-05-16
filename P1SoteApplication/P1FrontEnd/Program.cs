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

          public static void Login(string username, string password)
        {
              username = ""; password ="";string lname = ""; string fname = "";string address = "";
             P1RepoClass prc = new P1RepoClass();

            P1StoreBusinessClass cb = new P1StoreBusinessClass(prc);

             //Customer currentCustomer = cb.CurrentCustomer(username,password,lname,fname,address);
              //currentCustomer = cb.CurrentCustomer(username, secretcode);
             List<Customer> Customers = cb.CustomerList();
             //Login Attempts counter
            int loginAttempts = 0;

            //Simple iteration upto three times
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter username");
                username = Console.ReadLine();
                Console.WriteLine("Enter password");
                 password = Console.ReadLine();
                //currentCustomer = cb.CurrentCustomer();
                if (username != "IsValid" || password != "IsValid")
                    loginAttempts++;
                else
                    break;
             }

            //Display the result
            if (loginAttempts > 2)
                Console.WriteLine("Login failure");
            else
                Console.WriteLine("Login successful");
                ShowCustomerInfo();
        }    


        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to P1 Clearance Store");
            Console.WriteLine("1) Already a CSuromer: Login in");
            Console.WriteLine("2) Sign Up for New Account");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");
            string username = "";string password ="";string lname = ""; string fname = "";string address = "";
            switch (Console.ReadLine())
            {
                case "1":
                   Login(username,password);
                    break;
                case "2":
                    RegisterAccount(username,password,lname,fname,address);
                    break;
                case "3":
                    System.Environment.Exit(1);
                    break;
                default:
                    break;
               
            }   
        }

        //Login method
      
        //Register new Customer Account
        public static void RegisterAccount(string username, string lname, string fname,string address, string secretcode)
        {
            Console.Write("Enter username: ");
            Console.Write("Enter password: ");
            Console.Write("Renter password: ");
            Console.Write("Enter First name: ");
            Console.Write("Enter Last Name: ");
            Console.Write("Enter Address: ");

             username = Console.ReadLine();
             secretcode = Console.ReadLine();
             fname = Console.ReadLine();
             lname = Console.ReadLine();
             address = Console.ReadLine();

            //SqlCommand sqlComm = new SqlCommand();
             P1RepoClass prc = new P1RepoClass();

            P1StoreBusinessClass cb = new P1StoreBusinessClass(prc);

              Customer newCustomer = new Customer();
              Console.Write("Account Created");
          //sqlComm.CommandText = $" INSERT INTO P1StoreCustomer (Username, LastNanme, FirstName, Address, secretcode)  VALUES (@var)";
          //sqlComm.AddWithValue("@var", username, lname,fname, address, secretcode);

        }

        //Displays the Customer info
        public static void ShowCustomerInfo()
        {
            string username =""; string lname =""; string fname =""; string address = ""; string secretcode ="";
            P1RepoClass prc = new P1RepoClass();

            P1StoreBusinessClass cb = new P1StoreBusinessClass(prc);

            //Customer currentCustomer = new Customer();
            //currentCustomer = cb.CurrentCustomer(username,secretcode,lname,fname,address);
            List<Customer> Customers = cb.CustomerList();
            //string username = Console.ReadLine();
            //string secretcode = Console.ReadLine();
            //string fname = Console.ReadLine();
            //string lname = Console.ReadLine();
            //string address = Console.ReadLine();

             //Customer newCustomer;
            //SqlCommand sqlComm = new SqlCommand();

          //sqlComm.CommandText = $" SELECT * FROM P1StoreCustomer;";
          //sqlComm.AddWithValue("@var", username, lname,fname, address, secretcode);
            
            Console.WriteLine("Username" + username);
            //Console.Write();
            //Console.Write("Renter password: ");
            Console.Write(" First name: " + fname);
            Console.Write("Last Name: " + lname);
            Console.Write("Address: " + address);
            StoreOptions(username,secretcode);
        }

        //Select Store and Find items Logic
        public static void StoreOptions(string username, string password)
        {
             username = "";  password = "";
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
                case"1":
                   Login(username, password);
                    break;
                case "2":
                    //AddCartFunction;
                   ShowProducts();
                   Console.WriteLine("What would you like to buy?");
                    break;
                case "3":
                    ViewCart();
                    break;
                    case "4":
                  ShowProducts();
                    break;
                case "5":
                    Checkout();
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

        public static void AddToCart(int order, string ItemsOrdered, float OrderTotal)
        {
                 
                 ShowProducts();
              order = 0;
              
                 ItemsOrdered = "";
                 OrderTotal = 0.00f;
                 order = order + 1;
                 ItemsOrdered = ""; 
                 OrderTotal = OrderTotal + 1;
                
                  
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
            string username = "" ; string password = "";
            switch (Console.ReadLine())
            {
                case "1":
                   SelectStore();
                    break;
                case "2":
                    StoreOptions(username, password);
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
            string username = "" ; string password = "";
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
                   sqlComm.CommandText = $"SELECT * FROM * FROM [dbo].[P1StoreProduct] WHERE StoreID = 10";
                    break;
                case "2":
                    //Store 2;
                     sqlComm.CommandText = $"SELECT * FROM * FROM [dbo].[P1StoreProduct] WHERE StoreID = 15";
                    break;
                case "3":
                    //Store3;
                     sqlComm.CommandText = $"SELECT * FROM * FROM [dbo].[P1StoreProduct] WHERE StoreID = 20";
                    break;
                 case "4":
                    StoreOptions(username, password);
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
             P1RepoClass prc = new P1RepoClass();

            P1StoreBusinessClass pb = new P1StoreBusinessClass(prc);

              Product SelectProduct = new Product();
              Console.WriteLine("ProductID  Itemname     ItemDescription  ItemPrice    ItemQuanity}.....");
              List<Product> products = pb.ProductList();
              foreach(Product p in products)
              {
                  Console.WriteLine($"{p.ProductID}{p.Itemname}{p.ItemDescription}{p.ItemPrice}{p.ItemQuanity}.....");
              }
        }
        
        //Make and cancel purchases
        public static void Checkout()
        {
              
              string username = ""; string password = "";string ItemsOrdered = ""; float OrderTotal = 0.00f;
             P1RepoClass prc = new P1RepoClass();

            P1StoreBusinessClass ob = new P1StoreBusinessClass(prc);

              Orders newOrder = ob.NewOrders(ItemsOrdered,OrderTotal);
              //int orderCount = 0;
             
                 
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
                     ItemsOrdered = $"{newOrder.ItemsOrdered}";
                 OrderTotal = 0.00f; 
                    OrderTotal= OrderTotal + float.Parse($"{newOrder.OrderTotal}");
                    Console.WriteLine("Item Ordered was"+ ItemsOrdered + "and your total is"+ OrderTotal );
                   //SqlCommand sqlComm = new SqlCommand();

          //sqlComm.CommandText = $"INSERT INTO P1StoreOders (ItemsOrdered, OrderTotal ) VALUES  (@var);";
          //sqlComm.AddWithValue("@var", ItemsOrdered, OrderTotal);
                    StoreOptions(username, password);
                    break;
                case "2":
                    StoreOptions(username, password);
                    break;
                default:
                    break;
            
            }
        }



    
    }

}
