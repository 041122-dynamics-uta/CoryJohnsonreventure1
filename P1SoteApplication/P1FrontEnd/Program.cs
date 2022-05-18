using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using P1StoreBusiness;
using P1StoreDomain;
using P1Repository;

namespace P1FrontEnd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            P1RepoClass prc = new P1RepoClass();

            P1StoreBusinessClass cb = new P1StoreBusinessClass(prc);
            List<Customer> customers = cb.CustomerList();
            bool moveOn = false;// this is to signify that the user correctly entered the value.
            while (moveOn == false)
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
                        Login();
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
            
        }
        
        public static void MainMenu()
        {
             P1RepoClass prc = new P1RepoClass();

            P1StoreBusinessClass cb = new P1StoreBusinessClass(prc);
            List<Customer> customers = cb.CustomerList();
            bool moveOn = false;// this is to signify that the user correctly entered the value.
            while (moveOn == false)
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
                        Login();
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
        }

        //Login method
        public static void Login()
        {
              string username = ""; string secretcode ="";//string lname = ""; string fname = "";string address = "";
            
             P1RepoClass prc = new P1RepoClass();

            P1StoreBusinessClass cb = new P1StoreBusinessClass(prc);

              Customer currentCustomer = new Customer();
                  //string StoreUsername = $"{currentCustomer.Username}"; string storeSecretcode = $"{currentCustomer.secretcode}"; 
            //int loginAttempts = 0;

            //Simple iteration upto three times
            
            
                Console.WriteLine("Enter username");
                username = Console.ReadLine();
                Console.WriteLine("Enter password");
                 secretcode = Console.ReadLine();
               
                if (username != $"{currentCustomer.Username}" || secretcode != $"{currentCustomer.secretcode}")
                  {
                      Console.WriteLine("Login failure"); 
                      MainMenu();
                  } 
                else
                {
                     Console.WriteLine("Login successful");
                    ShowCustomerInfo();
                }
                   
             

            
        }    


        

        
      
        //Register new Customer Account
        public static void RegisterAccount(string username, string lname, string fname,string address, string secretcode)
        {
             P1RepoClass prc = new P1RepoClass();

            P1StoreBusinessClass cb = new P1StoreBusinessClass(prc);

              Customer newCustomer = new Customer();
              
            Console.Write("Enter username: ");
            username = Console.ReadLine();
            Console.Write("Enter password: ");
            secretcode = Console.ReadLine();
            Console.Write("Enter First name: "); 
            fname = Console.ReadLine();
            Console.Write("Enter Last Name: ");      
            lname = Console.ReadLine();  
            Console.Write("Enter Address: ");   
            address = Console.ReadLine();

            newCustomer = cb.NewCustomer(username,fname,lname,address,secretcode);

             
             
          
          

            
           
              Console.Write("Account Created");
              StoreOptions(username, secretcode);
          

        }

        //Displays the Customer info
        public static void ShowCustomerInfo()
        {
            string username ="";  string secretcode ="";//string lname =""; string fname =""; string address = "";
            P1RepoClass prc = new P1RepoClass();

            P1StoreBusinessClass cb = new P1StoreBusinessClass(prc);
            Customer CurrentCustomer = new Customer();

            
            Customer currentCustomer = cb.CurrentCustomer(username);
           
            
            Console.WriteLine("Username" + $"{currentCustomer.Username}");
            //Console.Write();
            //Console.Write("Renter password: ");
            Console.Write(" First name: " + $"{currentCustomer.FirstName}");
            Console.Write("Last Name: " + $"{currentCustomer.LastName}");
            Console.Write("Address: " + $"{currentCustomer.Address}");
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
                   Login();
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
