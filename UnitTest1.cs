namespace DDDWorkshop;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ShouldAddProductToTheCart()
    {
        var cart = new Cart();
        Assert.IsEmpty(cart.Products);
        cart.AddProduct(new Pencil());
        Assert.AreEqual(1,cart.Products.Count);
    }
}