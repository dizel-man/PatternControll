public class SugarCondiment : CondimensDecoratorBase
{
    private BeverageBase _beverage;

    public SugarCondiment(BeverageBase beverage)
    {
        _beverage = beverage;
        Description = _beverage.GetDescription() + " + Sugar";
    }

    public override double GetCost()
    {
        return _beverage.GetCost() + _beverage.sugarCost;// + стоимость сахара
    }
}
