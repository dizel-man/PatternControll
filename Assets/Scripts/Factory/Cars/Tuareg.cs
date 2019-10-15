﻿using UnityEngine;

public class Tuareg : Car
{
    private CarPartsFactory _factory;

    public Tuareg(CarPartsFactory factory)
    {
        _factory = factory;

        Name = "Tuareg";
        Body = "Jeep";
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
