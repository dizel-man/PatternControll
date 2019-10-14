public class GreenTea : BeverageBase
{
    int price = 125;

    public GreenTea()
    {
        Description = "Green leaf tea";
    }

    public override double GetCost()
    {
        return price;
    }
}
