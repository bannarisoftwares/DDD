using DDDWorkshop.domain;

namespace DDDWorkshop;

public class Product
{
    public Product(string name)
    {
        Name = name;
    }

    public Product(string name, Price price)
    {
        Name = name;
        Price = price;
    }


    public string Name { set; get; }
    public Price Price { set; get; }
}