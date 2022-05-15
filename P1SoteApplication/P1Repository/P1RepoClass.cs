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

         public List<Customer> CustomersList()
        {   
            string myQuery1 = "SELECT * FROM P1StoreCustomers;";
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
    }    }
}