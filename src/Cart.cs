namespace DDDWorkshop;

public class Cart
{
    public Cart()
    {
        Products = new List<Product>();
    }

    public IList<Product> Products { set; get; }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }
    
    public void AddProduct(Product product, int quantity)
    {
        for (var i = 0; i < quantity; i++)
        {
            Products.Add(product);
            
        }
    }
}