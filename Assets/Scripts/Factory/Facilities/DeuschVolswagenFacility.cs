using UnityEngine;
//здесь вынесены способы получения конкретных типов авто


namespace Factory
{

    public class DeuschVolswagenFacility : VolswagenFacility
    {
        public override Car CreateCar(string type)
        {
            Car car;
            CarPartsFactory factory = new DeuschCarPartsFactory();

            switch (type)
            {
                case "Golf":
                    car = new Golf(factory);
                    return car;

                case "Passat":
                    car = new Passat(factory);
                    return car;


                case "Tiguan":
                    car = new Tiguan(factory);
                    return car;


                case "Tuareg":
                    car = new Tuareg(factory);
                    return car;


                default:
                    break;
            }

            return null;
        }
    }
}
