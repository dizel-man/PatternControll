using UnityEngine;
//здесь вынесены способы получения конкретных типов авто
public class RussianVolswagenFacility : VolswagenFacility
{
    public override Car CreateCar(string type)
    {
        Car car = new Car();

        switch (type)
        {
            case "Golf":
                car = new RussianGolf();
                break;

            case "Passat":
                car = new RussianPassat();
                break;

            case "Tiguan":
                car = new RussianTiguan();
                break;

            case "Tuareg":
                car = new RussianTuareg();
                break;


            default:
                break;
        }

        return car;
    }
}
