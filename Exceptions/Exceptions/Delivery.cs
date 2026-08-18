public class Delivery
{
    public int Id { get; set; }
    public string CustomerName {  get; set; }
    public DeliveryStatus DeliveryStatus { get; set; }
    public override string ToString()
    {
        return $"{{\nId: {Id} ,   \nCusotmer: {CustomerName },   \nStatus:{DeliveryStatus}}}";
    }
}
