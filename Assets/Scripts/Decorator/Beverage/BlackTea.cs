public class BlackTea : BeverageBase
{
    int price = 25;
    public BlackTea()
    {
        Description = "Black tea from teabag";
    }

    public override double GetCost()
    {
        return price;
    }
}
