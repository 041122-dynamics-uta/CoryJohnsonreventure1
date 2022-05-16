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
        public Customer NewCustomer(string username, string LastName, string FirstName,string address, string secretcode)
        {
                string myQuery1 = $"INSERT INTO P1StoreCustomer (Username, LastNanme, FirstName, Address, secretcode)VALUES (@U, @L, @F,@a,@s);";
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
                command.Parameters.AddWithValue("@s", secretcode);
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
                        secretcode = secretcode

                    };
                    return c;
                }return null;
            }   
                
        }

        public Customer CurrentCustomer(string username, string LastName, string FirstName,string address, string secretcode)
        {
                string myQuery1 =  $"SELECT * FROM P1StoreCustomer WhHERE Username = @U;";
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
                command.Parameters.AddWithValue("@s", secretcode);
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
                        secretcode = secretcode

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
             string myQuery1 = $"SELECT * FROM P1StoreProducts;";
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
            string myQuery1 = $"SELECT * FROM P1StoreStore;";
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

        public Orders NewOrders(string ItemsOrdered, float OrderTotal)
        {
                  string myQuery1 = $"INSERT INTO P1StoreCustomer (itemOderred, OrderTotal )VALUES (@IO, @OT);";
            using (SqlConnection query1 = new SqlConnection(connectionString))
            {
             //The SqlCommand object uses the query text along with the SqlConnection object to open a connection and send the query.
                SqlCommand command = new SqlCommand(myQuery1, query1);
                command.Parameters.AddWithValue("@IO", ItemsOrdered);
                command.Parameters.AddWithValue("@OT", OrderTotal);
               
                command.Connection.Open();//open the connection to the Db
               int results = command.ExecuteNonQuery();//actually conduct the query.
                query1.Close();
                if(results == 1)
                {
                    Orders o = new Orders
                    {
                        Orderid = 100,
                        ItemsOrdered = ItemsOrdered,
                        OrderTotal = OrderTotal
                        

                    };
                    return o;
                }
               return null;
            }        
        
        }

        
    }  
        
}//EOC