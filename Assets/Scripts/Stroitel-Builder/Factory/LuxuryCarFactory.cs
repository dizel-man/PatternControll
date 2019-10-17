using UnityEngine;

namespace stroitel
{
     class LuxuryCarFactory : CarFactoryBase
    {
        public LuxuryCarFactory(CarBuilderBase builder) : base(builder)
        {

        }

        //дорогие автомобили
        public override Car Construct()
        {
            //делаем всё
            CarBuilder.BuildFrames();
            CarBuilder.BuildEngine();
            CarBuilder.BuildWheels();
            CarBuilder.BuildSafety();
            CarBuilder.BuildMultimedia();
            CarBuilder.BuildLuxury();

            return CarBuilder.GetCar();
        }
    }

}


