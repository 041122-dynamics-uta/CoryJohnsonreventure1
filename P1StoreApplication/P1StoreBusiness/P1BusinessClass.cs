using P1StoreDomain;
using P1Repository;

namespace P1StoreBusiness;
public class P1StoreBusinessClass
{
    //inject the dependency into the class
    private P1RepoClass _repo { get; set; }
    public P1StoreBusinessClass(P1RepoClass r)
    {
        this._repo = r;
    }

    public List<Customer> CustomerList()
    {
        List<Customer> cl = _repo.CustomersList();
        return cl;
    }

    public List<Product> ProductList()
    {
        List<Product> pl = _repo.ProductList();
        return pl;
    }

    public List<Store> StoreList()
    {
        List<Store> pl = _repo.StoreList();
        return pl;
    }

      public List<Orders> OrderList()
    {
        List<Orders> ot = _repo.OrderList();
        return ot;
    }

    public List<Orders> PastOrders()
    {
        List<Orders> ot = _repo.PastOrders();
        return ot;
    }

    public Product GetPtice(int productID)
    {
        Product pl = _repo.GetPrice(productID);
        return pl;
    }


    public Orders NewOrders(int CustomerID, int StoreID, int ProductID, int Quantity, float OrderTotal)
    {
        Orders ol = _repo.NewOrders(CustomerID, StoreID, ProductID, Quantity, OrderTotal);
        return ol;
    }

    public Customer CustomerLogin(string username, string password)
    {
            return new Customer("Ron", "Johnson", username, password);
            //Customer cl = _repo.CustomerLogin(username,password);
            //return  cl;
    }
     public Customer NewCustomer(string username, string lname, string fname,string address, string password)
    {
        bool Exist = _repo.CredentialChecker(username, password);
        
        Customer cl = _repo.NewCustomer(username,lname,fname,address, password);
        return cl;
    }

     public Customer CurrentCustomer(string username, string lname, string fname,string address, string password)
    {
        bool Exist = _repo.CredentialChecker(username, password);
        
        Customer cl = _repo.CurrentCustomer(username,lname,fname,address,password);
        return cl;
    }
}
