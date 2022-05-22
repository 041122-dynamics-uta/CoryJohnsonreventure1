namespace P1StoreDomain
{
    public class Orders
    {
       public Guid OrderID { get; set; } = new Guid();
       public Customer CustomerID { get; set; }= new Customer();
       public Store Store { get; set; } = new Store();
       public Dictionary<Product, int> Product { get; set; } =  new Dictionary<Product, int>();
      

        

 
        
    }
}