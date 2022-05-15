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
}
