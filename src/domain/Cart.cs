namespace DDDWorkshop.domain;

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

    public void RemoveProduct(Product product)
    {
        Products = Products.Where(pro => !pro.Name.Equals(product.Name)).ToList();
        
    } 
    public IList<string> RemoveProducts(IList<Product> product)
    {
        // Products = Products.Where(pro => !pro.Name.Equals(product.Name)).ToList();
        
       return product.Select(product => product.Name).ToList();
    }

}