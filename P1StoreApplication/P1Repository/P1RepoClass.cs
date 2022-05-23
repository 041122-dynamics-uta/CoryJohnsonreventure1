using System.Data.SqlClient;
using P1StoreDomain;



namespace P1Repository
{
    public class P1RepoClass 
    {
         public P1StoreMapperClass _mapper { get; set; }

         string connectionString = $"Server=tcp:coryjohnsonserver.database.windows.net,1433;Initial Catalog=CoryJohnsonDB;Persist Security Info=False;User ID=CoryJohnsonDB;Password=NewSouthAzureG0;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;" ;

         public P1RepoClass()
        {
            // this._repo = r;
            this._mapper = new P1StoreMapperClass();
        }


        //Customer
        public Customer NewCustomer(string username, string LastName, string FirstName,string address, string Password)
        {
                string myQuery1 = $"INSERT INTO [P1StoreCenter.Customer] (Username, LastNanme, FirstName, CustomerAddress, Password) VALUES (@U, @L, @F, @A,@P );";
            //this using block creates teh SqlConnection.
            // the SqlConnection is the object that communicates with the Db.
            using (SqlConnection query1 = new SqlConnection(connectionString))
            {
             //The SqlCommand object uses the query text along with the SqlConnection object to open a connection and send the query.
                SqlCommand command = new SqlCommand(myQuery1, query1);
                command.Parameters.AddWithValue("@U", username);
                command.Parameters.AddWithValue("@L", LastName);
                command.Parameters.AddWithValue("@F", FirstName);
                command.Parameters.AddWithValue("@A", address);
                command.Parameters.AddWithValue("@P", Password);
                command.Connection.Open();//open the connection to the Db
               int results = command.ExecuteNonQuery();//actually conduct the query.

                query1.Close();
                if(results == 1)
                {
                    Customer c = new Customer
                    {
                        CustomerID = 10,
                        Username = username,
                        LastName = LastName,
                        FirstName = FirstName,
                        Address = address,
                        Password = Password,

                    };
                    return c;
                }return null;
            }   
                
        }

        public List<Orders> PastOrders()
        {
             string myQuery1 =  $"SELECT * FROM [dbo].[P1StoreCenter.Orders] WHERE CustomerID = @CID;";
            //throw new NotImplementedException();
            using (SqlConnection query1 = new SqlConnection(connectionString))
            {
             //The SqlCommand object uses the query text along with the SqlConnection object to open a connection and send the query.
                SqlCommand command = new SqlCommand(myQuery1, query1);
                  //command.Parameters.AddWithValue("@CID", CustomerID);
                command.Connection.Open();//open the connection to the Db
                SqlDataReader results = command.ExecuteReader();//actually conduct the query.

                //query the FamilyRepository Db for the list of members
                //USE ADO.NET .........
                //use the mapper to transfer the falues in to Member objects in a List<Member>.
                List<Orders> ol = new List<Orders>();
                while (results.Read())
                {
                    ol.Add(this._mapper.DboToP1StoreOrders(results));//send in the row of the reader to be mapped.
                }

                query1.Close();
                return ol;
            
            }
             
        }

        public Product GetPrice(int ProductID)
        {
            string myQuery1 =  $"SELECT ItemPrice FROM [dbo].[P1StoreCenter.Products] WHERE ProductID = @PID;";
            //throw new NotImplementedException();
             using (SqlConnection query1 = new SqlConnection(connectionString))
            {
             //The SqlCommand object uses the query text along with the SqlConnection object to open a connection and send the query.
                SqlCommand command = new SqlCommand(myQuery1, query1);
                command.Parameters.AddWithValue("@PID", ProductID);
                command.Connection.Open();//open the connection to the Db
                int results = command.ExecuteNonQuery();//actually conduct the query. 
                query1.Close();

                 if(results == 1)
                {
                    Product p = new Product
                    {
                        
                     ProductID = ProductID

                    };
                    return p;
                }
            }   return null;
             
        }

        public bool CredentialChecker(string username, string password)
        {
             string myQuery1 =  $"SELECT FirstName, LastNanme FROM [dbo].[P1StoreCenter.Customer] WHERE Username = @U AND Password = @P;";
            //throw new NotImplementedException();

            using (SqlConnection query1 = new SqlConnection(connectionString))
            {
             //The SqlCommand object uses the query text along with the SqlConnection object to open a connection and send the query.
                SqlCommand command = new SqlCommand(myQuery1, query1);
                command.Parameters.AddWithValue("@U", username);
                command.Parameters.AddWithValue("@P", password);
                command.Connection.Open();//open the connection to the Db
                SqlDataReader? results = command.ExecuteReader();//actually conduct the query. 
                query1.Close();

                if(results == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            } 
        }

        public Customer CurrentCustomer(string username, string LastName, string FirstName,string address, string Password)
        {
                string myQuery1 =  $"SELECT * FROM [dbo].[P1StoreCenter.Customer] WHERE Username = @U AND Password = @P;";
            //this using block creates teh SqlConnection.
            // the SqlConnection is the object that communicates with the Db.
            using (SqlConnection query1 = new SqlConnection(connectionString))
            {
             //The SqlCommand object uses the query text along with the SqlConnection object to open a connection and send the query.
                SqlCommand command = new SqlCommand(myQuery1, query1);
                command.Parameters.AddWithValue("@U", username);
                command.Parameters.AddWithValue("@L", LastName);
                command.Parameters.AddWithValue("@F", FirstName);
                command.Parameters.AddWithValue("@a", address);
                command.Parameters.AddWithValue("@P", Password);
                command.Connection.Open();//open the connection to the Db
               int results = command.ExecuteNonQuery();//actually conduct the query.

                query1.Close();
                if(results == 1)
                {
                    Customer c = new Customer
                    {
                        CustomerID = 100,
                        Username = username,
                        LastName = LastName,
                        FirstName = FirstName,
                        Address = address,
                        Password = Password

                    };
                    return c;
                }
            }   return null;
                
        }

        public Customer CustomerLogin(string username, string password)
        {
            string myQuery1 =  $"SELECT * FROM [dbo].[P1StoreCenter.Customer] WHERE Username = @U AND Password = @P;";
            //this using block creates teh SqlConnection.
            // the SqlConnection is the object that communicates with the Db.
            using (SqlConnection query1 = new SqlConnection(connectionString))
            {
             //The SqlCommand object uses the query text along with the SqlConnection object to open a connection and send the query.
                SqlCommand command = new SqlCommand(myQuery1, query1);
                command.Parameters.AddWithValue("@U", username);
                command.Parameters.AddWithValue("@P", password);
                command.Connection.Open();//open the connection to the Db
               int results = command.ExecuteNonQuery();//actually conduct the query.

                query1.Close();
                if(results == 1)
                {
                    Customer c = new Customer
                    {
                        //CustomerID = 100,
                        Username = username,
                        Password = password

                    };
                    return c;
                }
            }   return null;
        }
        
         public List<Customer> CustomersList()
        {   
            string myQuery1 = $"SELECT * FROM P1StoreCustomer;";
            //this using block creates teh SqlConnection.
            // the SqlConnection is the object that communicates with the Db.
            using (SqlConnection query1 = new SqlConnection(connectionString))
            {
             //The SqlCommand object uses the query text along with the SqlConnection object to open a connection and send the query.
                SqlCommand command = new SqlCommand(myQuery1, query1);
                command.Connection.Open();//open the connection to the Db
                SqlDataReader results = command.ExecuteReader();//actually conduct the query.

                //query the FamilyRepository Db for the list of members
                //USE ADO.NET .........
                //use the mapper to transfer the falues in to Member objects in a List<Member>.
                List<Customer> cl = new List<Customer>();
                while (results.Read())
                {
                    cl.Add(this._mapper.DboToP1StoreCustomer(results));//send in the row of the reader to be mapped.
                }

                query1.Close();
                return cl;
            
            }
        }

        public List<Product> ProductList()
        {
             string myQuery1 = $"SELECT * FROM [dbo].[P1StoreCenter.Products]";
              using (SqlConnection query1 = new SqlConnection(connectionString))
            {
             //The SqlCommand object uses the query text along with the SqlConnection object to open a connection and send the query.
                SqlCommand command = new SqlCommand(myQuery1, query1);
                command.Connection.Open();//open the connection to the Db
                SqlDataReader results = command.ExecuteReader();//actually conduct the query.

                //query the FamilyRepository Db for the list of members
                //USE ADO.NET .........
                //use the mapper to transfer the falues in to Member objects in a List<Member>.
                List<Product> pl = new List<Product>();
                while (results.Read())
                {
                    pl.Add(this._mapper.DboToP1StoreProduct(results));//send in the row of the reader to be mapped.
                }

                query1.Close();
                return pl;
            
            }
        }

        public List<Store> StoreList()
        {
            string myQuery1 = $"SELECT * FROM [dbo].[P1StoreCenter.StoreS];";
              using (SqlConnection query1 = new SqlConnection(connectionString))
            {
             //The SqlCommand object uses the query text along with the SqlConnection object to open a connection and send the query.
                SqlCommand command = new SqlCommand(myQuery1, query1);
                command.Connection.Open();//open the connection to the Db
                SqlDataReader results = command.ExecuteReader();//actually conduct the query.

                //query the FamilyRepository Db for the list of members
                //USE ADO.NET .........
                //use the mapper to transfer the falues in to Member objects in a List<Member>.
                List<Store> pl = new List<Store>();
                while (results.Read())
                {
                    pl.Add(this._mapper.DboToP1StoreStore(results));//send in the row of the reader to be mapped.
                }

                query1.Close();
                return pl;
             }    
        
        }

        public List<Orders> OrderList()
        {
                 string myQuery1 = $"SELECT * FROM [dbo].[P1StoreCenter.Orders]";
              using (SqlConnection query1 = new SqlConnection(connectionString))
            {
             //The SqlCommand object uses the query text along with the SqlConnection object to open a connection and send the query.
                SqlCommand command = new SqlCommand(myQuery1, query1);
                command.Connection.Open();//open the connection to the Db
                SqlDataReader results = command.ExecuteReader();//actually conduct the query.

                //query the FamilyRepository Db for the list of members
                //USE ADO.NET .........
                //use the mapper to transfer the falues in to Member objects in a List<Member>.
                List<Orders> ot = new List<Orders>();
                while (results.Read())
                {
                    ot.Add(this._mapper.DboToP1StoreOrders(results));//send in the row of the reader to be mapped.
                }

                query1.Close();
                return ot;
             }    
        }
        public Orders NewOrders(int CustomerID, int StoreID, int ProductID, int Quantity, float OrderTotal)
        {
                  string myQuery1 = $"INSERT INTO [P1StoreCenter.Orders] (OrderID, CustomerID_FK, StoreID_FK, ProductID_FK, OrderQuantity, OrderTotal) VALUES (NewID(),@CID,@@SID,@PID,@Q,@OT);";
            using (SqlConnection query1 = new SqlConnection(connectionString))
            {
             //The SqlCommand object uses the query text along with the SqlConnection object to open a connection and send the query.
                SqlCommand command = new SqlCommand(myQuery1, query1);
                command.Parameters.AddWithValue("@CID", CustomerID);
                 command.Parameters.AddWithValue("@SID", StoreID);
                command.Parameters.AddWithValue("@PID", ProductID);
                command.Parameters.AddWithValue("@F", Quantity);
                command.Parameters.AddWithValue("@OT", OrderTotal);
                command.Connection.Open();//open the connection to the Db
               int results = command.ExecuteNonQuery();//actually conduct the query.
                query1.Close();
                if(results == 1)
                {
                    Orders o = new Orders
                    {
                       
                        
                        Quantity = 1,
                        OrderTotal = 1,
                        

                    };
                    return o;
                }
               return null;
            }        
        
        }

        
    }  
        
}//EOC