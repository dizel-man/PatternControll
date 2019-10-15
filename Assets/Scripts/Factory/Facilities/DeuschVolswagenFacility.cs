using UnityEngine;
//здесь вынесены способы получения конкретных типов авто
public class DeuschVolswagenFacility : VolswagenFacility
{
    public override Car CreateCar(string type)
    {
        Car car = new Car();

        switch (type)
        {
            case "Golf":
                car = new DeuschGolf();
                break;

            case "Passat":
                car = new DeuschPassat();
                break;

            case "Tiguan":
                car = new DeuschTiguan();
                break;

            case "Tuareg":
                car = new DeuschTuareg();
                break;

            default:
                break;
        }

        return car;
    }
}
