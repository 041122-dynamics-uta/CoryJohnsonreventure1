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

    public Orders NewOrders(string ItemsOrdered, float OrderTotal)
    {
        Orders ol = _repo.NewOrders(ItemsOrdered,OrderTotal);
        return ol;
    }

    
     public Customer NewCustomer(string username, string lname, string fname,string address, string secretcode)
    {
        Customer cl = _repo.NewCustomer(username,lname,fname,address,secretcode);
        return cl;
    }

     public Customer CurrentCustomer(String Username)
    {
        Customer cl = _repo.CurrentCustomer(Username);
        return cl;
    }
}
