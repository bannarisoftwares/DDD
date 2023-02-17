using DDDWorkshop.domain;

namespace DDDWorkshop;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ShouldAddProductsToTheCart()
    {
        var cart = new Cart();
        Assert.IsEmpty(cart.Products);
        cart.AddProduct(new Product("Apple pencil"));
        cart.AddProduct(new Product("Sony Wireless headphone"));
        Assert.AreEqual(2,cart.Products.Count);
    }
    
    [Test]
    public void ShouldAddProductsWithQuantityInToTheCart()
    {
        var cart = new Cart();
        Assert.IsEmpty(cart.Products);
        cart.AddProduct(new Product("Apple pencil"),2);
        Assert.AreEqual(2,cart.Products.Count);
    }
    
    [Test]
    public void ShouldRemoveProductsWithAllQuantityInTheCart()
    {
        var cart = new Cart();
        Assert.IsEmpty(cart.Products);
        cart.AddProduct(new Product("Apple pencil"),2);
        Assert.AreEqual(2,cart.Products.Count);
        
        cart.RemoveProduct(new Product("Apple pencil"));
        
        Assert.IsEmpty(cart.Products);
    }
}