namespace P1StoreDomain;
public class Customer
{

        //Customer table items
        public int CustomerID { get; set; } 
        public string? Username { get; set; } 
        public string? LastName { get; set; } 
        public string? FirstName { get; set; }
        public string? Address { get; set; } 

        public string? Password { get; set; }= "";
        public DateTime DateCreated { get; set; } = DateTime.Now;

        public Customer( string Username, string LastName, string FirstName, string Address, string Password)
        { 
                this.CustomerID = -1;
                this.Username = Username;
                this.LastName = LastName;
                this.FirstName = FirstName;
                this.Address = Address;
                this.Password = Password;                                            
        }
                  

        




       
}
