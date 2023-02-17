namespace DDDWorkshop;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var cart = new Cart();
        cart.AddProduct(new Apple());
        cart.AddProduct(new Pencil());
        Assert.Pass();
    }
}