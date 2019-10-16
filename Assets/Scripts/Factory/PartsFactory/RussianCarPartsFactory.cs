using UnityEngine;
//сборка Российской машины


namespace Factory
{
    public class RussianCarPartsFactory : CarPartsFactory
    {
        public override Engine CreateEngine()
        {
            //пусть  у России бензиновый движок
            return new GasolineEngine();
        }

        public override Paint CreatePaints()
        {
            //пусть  у России черный цвет
            return new BlackPaint();
        }

        public override Wheels CreateWheels()
        {
            //пусть  у России средние диски
            return new MediumWheels();
        }
    }

}


