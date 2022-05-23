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
            List<Store> StoreOptions;
            List<Product> StoreProducts;
             List<Orders> pastOrders;
            Product PriceItem;
            int customerID;
            int storeID;
           //MainMenu to login or register
           int OrderQuantity = 0;
           float TotalOrder = 0.00f;
           Orders ChekoutOrder;
          
            Console.WriteLine("Welcome to P1 Clearance Store");
           
            //Console.WriteLine("3) Exit");
            //Console.Write("\r\nSelect an option: ");
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
                        Console.WriteLine($"Welcome,{LoggedInCuster.Username}");
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
                              
                    
                        LoggedInCuster = cb.NewCustomer(fname,lname,address,username,password);
                        if(LoggedInCuster == null)
                        {
                                continue;
                        }
                        else break;
                   
                //Console.Write("Account Created");
             
                 } 

            do
            {
                   Console.WriteLine("P1  Store Center");
             Console.WriteLine("How can we help you?");
             Console.WriteLine("1) Show Stores");
             Console.WriteLine("2) View Products");
            
            key =Console.ReadKey();
            //Console.WriteLine(key.Key.ToString());
            }
            while(String.Compare(key.Key.ToString(), "D1")!= 0 && 
            String.Compare(key.Key.ToString(), "D2")!= 0 && String.Compare(key.Key.ToString(), "D3")!= 0 );
            }
            
            while(true)
            {
                        if(String.Compare(key.Key.ToString(), "D1")== 0 )
                        {
                             StoreOptions = cb.StoreList();

                            foreach (Store s in StoreOptions)
                            {
                                Console.WriteLine($"The member is {s.StoreID} {s.StoreName} {s.StoreLocation}");
                            }
                            Console.WriteLine("Witch Stoe would like to shop at?");
                             storeID = Convert.ToInt32(Console.ReadLine());
                        }
                        else if(String.Compare(key.Key.ToString(), "D2")== 0)
                        {
                            pastOrders = cb.PastOrders();

                            foreach (Orders o in pastOrders)
                            {
                                Console.WriteLine($"The member is {o.OrderID} {o.CustomerID}  {o.Quantity} {o.Product} {o.StoreID}");
                            }
                            Console.WriteLine("Witch Stoe would like to shop at?");
                             storeID = Convert.ToInt32(Console.ReadLine());
                        }
                        else if(String.Compare(key.Key.ToString(), "D3")== 0 )
                        {
                            StoreProducts = cb.ProductList();

                            foreach (Product p in StoreProducts)
                            {
                                Console.WriteLine($" {p.ProductID} {p.Itemname} {p.ItemDescription} {p.ItemPrice}");
                            }
                             Console.WriteLine("Witch item would like to purchase?");
                            int productID = Convert.ToInt32(Console.ReadLine());
                             PriceItem = cb.GetPtice(productID);
                            float itemPrice = Convert.ToInt16($"{PriceItem.ItemPrice}");
                                Console.WriteLine("Would you like to purchase this item");
                                string Response = Console.ReadLine();
                                if(Response == "yes" || Response == "y")
                                {
                                             OrderQuantity = OrderQuantity + 1;
                                             TotalOrder = TotalOrder +  itemPrice;
                                }
                                else if(Response == "no" || Response == "n")
                                {
                                        continue;
                                }

                            //Ask to Ckeckout
                            customerID = Convert.ToInt16(($"{LoggedInCuster.CustomerID}"));
                            storeID = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Do you want to checkout?");
                             if(Response == "yes" || Response == "y")
                                {
                                      if(TotalOrder > 500)
                                      {
                                          Console.WriteLine("Order is too high Please make adjustments.");
                                          continue;
                                      }
                                      else
                                      {
                                          ChekoutOrder = cb.NewOrders(customerID, storeID, productID,  OrderQuantity, TotalOrder);       
                                      }
                                      
                                }
                                else if(Response == "no" || Response == "n")
                                {
                                        continue;
                                }

                        }
                        else if (String.Compare(key.Key.ToString(), "D4")== 0 )
                        {
                            System.Environment.Exit(1);
                        }
            }
          
            
            
           
               
        



    
        }
    }
}
