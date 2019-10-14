public class ChocolateCondiment : CondimensDecoratorBase
{
    private BeverageBase _beverage;

    public ChocolateCondiment(BeverageBase beverage)
    {
        _beverage = beverage;
        Description = _beverage.GetDescription() + " + Chocolate";
    }

    public override double GetCost()
    {
        return _beverage.GetCost() + _beverage.chocolateCost;// + стоимость шеколада
    }
}
