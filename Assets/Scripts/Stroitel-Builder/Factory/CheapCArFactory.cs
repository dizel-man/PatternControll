
using UnityEngine;

namespace stroitel
{

     class CheapCArFactory : CarFactoryBase
    {
        public CheapCArFactory(CarBuilderBase builder): base(builder)
        {

        }

        //дешовые автомобили
        public override Car Construct()
        {
            //делаем только
            CarBuilder.BuildFrames();
            CarBuilder.BuildEngine();
            CarBuilder.BuildWheels();
            CarBuilder.BuildSafety();


            return CarBuilder.GetCar();
        }
    }

}
