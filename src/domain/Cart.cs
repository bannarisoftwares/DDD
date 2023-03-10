namespace DDDWorkshop.domain;

public class Cart
{
    public Cart()
    {
        Products = new List<Product>();
    }

    public List<Product> Products { set; get; }
    public bool IsCheckedOut { set; get; }

    public void UpdateCheckedOutStatus(bool status)
    {
        IsCheckedOut = status;
    }

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
        Products.RemoveAll(p => p.Name.Equals(product.Name));
    }

    public IList<string> RemoveProducts(IList<Product> product)
    {
        // Products = Products.Where(pro => !pro.Name.Equals(product.Name)).ToList();

        return product.Select(product => product.Name).ToList();
    }
}