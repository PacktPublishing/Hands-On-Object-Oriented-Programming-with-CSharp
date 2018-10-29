public class Order {
    public int OrderId { get; set; }
    public List<OrderItem> OrderItems { get; set; }
    public DateTime OrderTime { get; set; }
    public Customer Customer { get; set; }
}