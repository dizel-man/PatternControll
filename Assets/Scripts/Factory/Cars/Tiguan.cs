using UnityEngine;

public class Tiguan : Car
{
    private CarPartsFactory _factory;

    public Tiguan(CarPartsFactory factory)
    {
        _factory = factory;
        Name = "Tiguan";
        Body = "Crossover";

    }

    public override void Configure()
    {
        Debug.Log("Name: " + Name);
        Debug.Log("Body: " + Body);

        Engine = _factory.CreateEngine();
        PaintColor = _factory.CreatePaints();
        Wheels = _factory.CreateWheels();
    }
}
