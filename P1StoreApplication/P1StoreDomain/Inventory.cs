namespace P1StoreDomain
{
    public class Inventory
    {
         public Dictionary<Product, int> Product { get; set; } =  new Dictionary<Product, int>();
      
        public Store Store { get; set; }= new Store();
       
      
 

    }
}