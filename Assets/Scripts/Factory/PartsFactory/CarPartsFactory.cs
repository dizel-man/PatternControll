using UnityEngine;

public abstract class CarPartsFactory 
{
    public abstract Engine CreateEngine();
    public abstract Paint CreatePaints();
    public abstract Wheels CreateWheels();
}
