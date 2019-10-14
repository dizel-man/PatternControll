public class Espresso : BeverageBase
{
    int price = 150;

    public Espresso()
    {
        Description = "Small portion of strong coffee";
    }

    public override double GetCost()
    {
        return price;
    }
}