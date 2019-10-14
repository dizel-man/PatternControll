using UnityEngine;

public abstract class BeverageBase
{
    protected string Description = "";

    public int milkCost = 50;
    public int chocolateCost = 70;
    public int sugarCost = 10;

    public string GetDescription()
    {
        return Description;
    }

    public abstract double GetCost();

}
