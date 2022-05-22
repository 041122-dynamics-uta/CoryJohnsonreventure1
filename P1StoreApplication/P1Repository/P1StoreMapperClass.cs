using System.Data.SqlClient;
using P1StoreDomain;


namespace P1Repository
{
    public class P1StoreMapperClass
    {
        internal Customer DboToP1StoreCustomer(SqlDataReader reader)
        {
            Customer c = new Customer
            {
                CustomerID = (int)reader[0],
                Username = (string)reader[1],
                LastName = (string)reader[2],
                FirstName = (string)reader[3],
                Address = (string)reader[4],
                Password= (string)reader[5],

               
            };
            return c;
        }
        internal Store DboToP1StoreStore(SqlDataReader reader)
        {
            Store s = new Store
            {
                StoreID = (int)reader[0],
                StoreName = (string)reader[1],
                StoreLocation = (string)reader[2],
             
                

               
            };
            return s;
        }
        internal Product DboToP1StoreProduct(SqlDataReader reader)
        {
            Product p = new Product
            {
                ProductID = (int)reader[0],
                Itemname = (string)reader[1],
                ItemDescription = (string)reader[2],
                ItemPrice  = (float)reader[3],
               

               
            };
            return p;
        }

        /**internal Orders DboToP1StoreOrders(SqlDataReader reader)
        {
                Orders o = new Orders
            {
                OrderID = (int)reader[0],
                OrderQuantity = (string)reader[1],
                OrderTotal = (float)reader[2]
                
                
                

               
            };
            return o;
        }**/
    
    }

    
}