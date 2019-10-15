using UnityEngine;

public abstract class Car 
{
    protected string Name = "";
    protected string Body = "Caravan";

    protected Engine Engine;
    protected Paint PaintColor;
    protected Wheels Wheels;


    public abstract void Configure();
    

    public void AssembleBody()
    {
        Debug.Log("Кузов установлен");
    }

    public void InstallEngene()
    {
        Debug.Log("Двигатель установлен");
    }

    public void Paint()
    {
        Debug.Log("Покрашено");
    }

    public void InstallWheels()
    {
        Debug.Log("Калеса установлены");
    }

}
