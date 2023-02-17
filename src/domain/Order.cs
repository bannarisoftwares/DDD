namespace DDDWorkshop.domain;

public class Order
{
    public Order(List<Product> products)
    {
        Products = products;
    }

    public List<Product> Products { set; get; }
    
}