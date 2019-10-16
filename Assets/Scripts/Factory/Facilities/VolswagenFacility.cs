using UnityEngine;
//здесь отделена инфраструктура создания автомобиля

namespace Factory
{

    public abstract class VolswagenFacility
    {

        public Car GetCar(string type)
        {

            Car car = CreateCar(type);

            car.Configure();
            car.AssembleBody();
            car.InstallEngene();
            car.Paint();
            car.InstallWheels();

            return car;
        }

        public abstract Car CreateCar(string type);
    }

}
