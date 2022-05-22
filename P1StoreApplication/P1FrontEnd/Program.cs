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

            Customer LoggedInCuster;
            
           //MainMenu to login or register
            Console.WriteLine("Welcome to P1 Clearance Store");
           
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");
            ConsoleKeyInfo key ;
           
           
              
            do
            {
                 Console.WriteLine("1) Already a CSuromer: Login in");
            Console.WriteLine("2) Sign Up for New Account"); 
            key =Console.ReadKey();
            //Console.WriteLine(key.Key.ToString());
            }
            while(String.Compare(key.Key.ToString(), "D1")!= 0 && 
            String.Compare(key.Key.ToString(), "D2")!= 0 );

            while(true)
           {
                if(String.Compare(key.Key.ToString(), "D1")== 0 )
                {
                    Console.WriteLine("Enter username");
                    string username = Console.ReadLine();
                    Console.WriteLine("Enter password");
                    string password = Console.ReadLine();
                    LoggedInCuster = cb.CustomerLogin(username,password);
                    if(LoggedInCuster == null)
                    {
                        Console.WriteLine("No account with the specified username or password");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"Welcom,{LoggedInCuster.FirstName}");
                    }break;

                }    
             
                else if(String.Compare(key.Key.ToString(), "D2")== 0)
                {
               
                    string fname;
                    string lname;
                    string address;
                    string username;
                    string password;
                    do
                    {
                            Console.Write("Enter First name: "); 
                        fname = Console.ReadLine();
                        Console.Write("Enter Last Name: "); 
                        lname = Console.ReadLine(); 
                        Console.Write("Enter Address: "); 
                        address = Console.ReadLine(); 
                            if(fname.Length > 30 || lname.Length > 30)
                            {
                                Console.Write("First  and/or last name is too long must be less than 31 character in length. ");
                                continue;
                            }
                            else
                                break;
                    }
                    while(fname.Length > 30 || lname.Length > 30);
               
                    do
                    {
                            Console.Write("Enter username: ");
                            username = Console.ReadLine();
                            Console.Write("Enter password: ");
                            password = Console.ReadLine();
                            if(username.Length > 30 || password.Length > 30)
                            {
                                Console.Write("Usaername and/or Passwortd is too long must be less than 31 character in length. ");
                                continue;
                            }
                        }
                        while(username.Length > 30 || password.Length > 30); 
                              
                    
                        LoggedInCuster = cb.CurrentCustomer(fname,lname,address,username,password);
                        if(LoggedInCuster == null)
                        {
                                continue;
                        }
                        else break;
                   
                //Console.Write("Account Created");
             
                 } 

             
            //Console.Clear();
            Console.WriteLine("P1 Clearance Store Menu");
             Console.WriteLine("Make a Selection");
            Console.WriteLine("1) Show Stores");
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
                   //Show Stores
                    break;
                case "2":
                    //AddCartFunction;
                   
                   Console.WriteLine("What would you like to buy?");
                    break;
                case "3":
                    //ViewCart
                    //Prompt for Checkout
                    break;
                    case "4":
                  //ShowProducts();
                    break;
                case "5":
                    //Checkout();
                    break;
                case "6":
                    //Checkout();
                    break;
                case "7":
                    System.Environment.Exit(1);
                    break;
                default:
                    break;
               
            }   
        
           
                /**Console.WriteLine("Username" + $"{currentCustomer.Username}");
                    //Console.Write();
                    //Console.Write("Renter password: ");
                    Console.Write(" First name: " + $"{currentCustomer.FirstName}");
                    Console.Write("Last Name: " + $"{currentCustomer.LastName}");
                    Console.Write("Address: " + $"{currentCustomer.Address}");**/
                        
                        
                            //System.Environment.Exit(1);
                        
                            //Showw Stores

                    //readonly int storeID;
                
                /** Console.WriteLine("Welcome to P1 Clearance Store");
                    Console.WriteLine("Select Store");
                    Console.WriteLine("1) Store 1");
                    Console.WriteLine("2) Store 2");
                    Console.WriteLine("3) Store 3");
                    Console.WriteLine("4) Back To Customer Account Info");
                    Console.WriteLine("5) Exit");
                    
        
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
                            break;
                        case "5":
                            System.Environment.Exit(1);
                            break;
                        default:
                            break;**/


                    //Show Products

                        /**P1StoreBusinessClass pb = new P1StoreBusinessClass(prc);

                    Product SelectProduct = new Product();
                    Console.WriteLine("ProductID  Itemname     ItemDescription  ItemPrice    ItemQuanity}.....");
                    List<Product> products = pb.ProductList();
                    foreach(Product p in products)
                    {
                        Console.WriteLine($"{p.ProductID}{p.Itemname}{p.ItemDescription}{p.ItemPrice}{p.ItemQuanity}.....");
                    }**/





                    //Add to Cart
                    //int OrderQuantity = 0;
                    
                        //ItemsOrdered = "";
                        //float OrderTotal = 0.00f;
                        
                        //order = order + 1;
                        //ItemsOrdered = ""; 
                        //OrderTotal = OrderTotal + 1;

                    //Finally Checkout
                    
            

                

            
            
                //Register new Customer Account
                

                //Displays the Customer info
            

                //Select Store and Find items Logic
                
                
                
                //View Products from store
                
                
            //Shop logic 
            

            
                
                //Make and cancel purchases
                /**public static void Checkout()
                {
                    
                    string username = ""; string password = "";
                    string ItemsOrdered = ""; float OrderTotal = 0.00f;
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
                }**/
              
        }
        



    
    }
    }
}
