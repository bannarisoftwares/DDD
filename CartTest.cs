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
        Assert.AreEqual(2, cart.Products.Count);
    }

    [Test]
    public void ShouldAddProductsWithQuantityInToTheCart()
    {
        var cart = new Cart();
        Assert.IsEmpty(cart.Products);
        cart.AddProduct(new Product("Apple pencil"), 2);
        Assert.AreEqual(2, cart.Products.Count);
    }

    [Test]
    public void ShouldRemoveProductsWithAllQuantityInTheCart()
    {
        var cart = new Cart();
        Assert.IsEmpty(cart.Products);
        cart.AddProduct(new Product("Apple pencil"), 2);
        Assert.AreEqual(2, cart.Products.Count);

        cart.RemoveProduct(new Product("Apple pencil"));

        Assert.IsEmpty(cart.Products);
    }

    [Test]
    public void ShouldDifferentiateTheCart()
    {
        var product = new Product("Apple pencil");
        var cart1 = new Cart();
        Assert.IsEmpty(cart1.Products);
        cart1.AddProduct(product, 2);

        var cart2 = new Cart();
        Assert.IsEmpty(cart2.Products);
        cart2.AddProduct(product, 2);

        Assert.AreNotEqual(cart1, cart2);
    }

    [Test]
    public void ShouldAddProductsToTheCartWithPrice()
    {
        var cart = new Cart();
        Assert.IsEmpty(cart.Products);
        cart.AddProduct(new Product("Apple pencil", new Price(2, CurrencyType.USD)));


        Assert.AreEqual(CurrencyType.USD, cart.Products.First().Price.CurrencyType);
        Assert.AreEqual(2, cart.Products.First().Price.Amount);
    }

    [Test]
    public void ShouldAddProductsToTheCartWithPricee()
    {
        var productName = "Apple pencil";
        var originalPrice = 125;
        var discount = new Discount(new Dictionary<string, Price>()
        {
            {productName, new Price(originalPrice, CurrencyType.USD)}
        });

        var discountedPrice = originalPrice - (discount.CompetitorPrice[productName].Amount * 10) / 100;

        var cart = new Cart();
        Assert.IsEmpty(cart.Products);
        cart.AddProduct(new Product(productName, new Price(discountedPrice, CurrencyType.USD)));


        Assert.AreEqual(CurrencyType.USD, cart.Products.First().Price.CurrencyType);
        Assert.AreEqual(2, cart.Products.First().Price.Amount);
    }
    
    [Test]
    public void ShouldCreateOrderFromTheCart()
    {
        var productName = "Apple pencil";
        
        var cart = new Cart();
        Assert.IsEmpty(cart.Products);
        cart.AddProduct(new Product(productName, new Price(2, CurrencyType.USD)));
        cart.AddProduct(new Product(productName, new Price(2, CurrencyType.USD)));

        Order order = new Order(cart.Products);
        cart.UpdateCheckedOutStatus(true);


        Assert.AreEqual(2, order.Products.Count);
    }
}