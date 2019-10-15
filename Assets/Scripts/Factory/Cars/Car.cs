using UnityEngine;

public class Car 
{
    protected string Name = "";
    protected string Engine = "Diesel";
    protected string PaintColor = "White";
    protected string Wheels = "16 inch";
    protected string Body = "Caravan";

    public void Configure()
    {
        Debug.Log("Создаём:" + Name);
        Debug.Log("Двигатель:" + Engine);
        Debug.Log("Кузов:" + Body);
        Debug.Log("Цвет:" + PaintColor);
        Debug.Log("Колеса:" + Wheels);
    }

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
