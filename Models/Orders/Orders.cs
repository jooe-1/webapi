namespace webapi.Models.Orders;

public class Orders
{
    
        public int Id { get; set; }
        public string CustomerName { get; set; } 
        public string Status { get; set; } 
        public decimal TotalPayment { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
    
}