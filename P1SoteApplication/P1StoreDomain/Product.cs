namespace P1StoreDomain
{
    public class Product
    {
        public int ProductID { get; set; } = -1;
        public string? Itemname { get; set; } = "";

        public string? ItemDescription { get; set; } ="'";
        public float ItemPrice { get; set; }= -1;
        public int ItemQuanity { get; set; } = -1;
    }
}