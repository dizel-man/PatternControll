using UnityEngine;
//сборка Немецкой машины
public class DeuschCarPartsFactory : CarPartsFactory
{
    public override Engine CreateEngine()
    {
        //пусть  у Германии дизельный движок
        return new DieselEngine();
    }

    public override Paint CreatePaints()
    {
        //пусть  у Германии белый цвет
        return new WhitePaint();
    }

    public override Wheels CreateWheels()
    {
        //пусть  у Германии большие диски
        return new BigWheels();
    }
}
