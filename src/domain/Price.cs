namespace DDDWorkshop.domain;

public class Price
{
    public Price(int amount, CurrencyType currencyType)
    {
        Amount = amount;
        CurrencyType = currencyType;
    }

    public int Amount { set; get; }
    public CurrencyType CurrencyType { set; get; }
}

public enum CurrencyType
{
    USD
}