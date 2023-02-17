namespace DDDWorkshop.domain;

public class Discount
{
    public Discount(Dictionary<string, Price> competitorPrice)
    {
        CompetitorPrice = competitorPrice;
    }

    public Dictionary<string, Price> CompetitorPrice { set; get; }
}