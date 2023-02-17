namespace DDDWorkshop;

public class Cart
{
    public Cart()
    {
        Products = new List<IProduct>();
    }

    public IList<IProduct> Products { set; get; }

    public void AddProduct(IProduct product)
    {
        Products.Add(product);
    }
}