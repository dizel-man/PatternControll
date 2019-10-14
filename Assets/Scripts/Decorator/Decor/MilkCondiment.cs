public class MilkCondiment : CondimensDecoratorBase
{
    private BeverageBase _beverage;

    public MilkCondiment(BeverageBase beverage)
    {
        _beverage = beverage;
        Description = _beverage.GetDescription() + " + Milk";
    }
    
    public override double GetCost()
    {
        return _beverage.GetCost() + _beverage.milkCost;// + стоимость молока
    }
}  
