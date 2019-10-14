using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunDecorator : MonoBehaviour
{
    private BeverageBase espresso = new Espresso();
    private BeverageBase blackTea = new BlackTea();
    private BeverageBase greenTea = new GreenTea();


    //многоуровневость с добавлением функциональности

    //капучино - это простой экспрессо с молоком и с сахором
    private BeverageBase capuccino = new SugarCondiment(new MilkCondiment(new Espresso()));
    //зеленый чай - это простой чай с сахором
    private BeverageBase greenTeaWithSugar = new SugarCondiment(new GreenTea());


    void Start()
    {
       
        PrintBeverage(espresso);
        PrintBeverage(blackTea);
        PrintBeverage(greenTea);
        Debug.Log("--------");
        PrintBeverage(capuccino);
        PrintBeverage(greenTeaWithSugar);
    }

    void PrintBeverage(BeverageBase bever)
    {
        Debug.Log("описание: " + bever.GetDescription());
        Debug.Log("стоимость: " + bever.GetCost());
    }

}
