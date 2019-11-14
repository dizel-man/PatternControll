using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Конкретные Посредники реализуют совместное поведение, координируя
// отдельные компоненты.

//Конкретный посредник содержит код взаимодействия нескольких компонентов между собой. 
//Зачастую этот объект не только хранит ссылки на все свои компоненты, но и сам их создаёт, 
//управляя дальнейшим жизненным циклом.

public class ConcreteMediator : Imediator
{

    private Component1 _component1;

    private Component2 _component2;

    public ConcreteMediator(Component1 component1, Component2 component2)
    {
        this._component1 = component1;
        this._component1.SetMediator(this);
        this._component2 = component2;
        this._component2.SetMediator(this);
    }

    public void Notify(object sender, string ev)
    {
        if (ev == "A")
        {
            Debug.Log("Mediator отриагировал на A and triggers folowing operations:");
            Debug.Log("Mediator включает метод DoC");
            this._component2.DoC();
           
        }
        if (ev == "D")
        {
            Debug.Log("Mediator отриагировал на D and triggers following operations:");
            Debug.Log("Mediator включает component1 метод DoB");
            this._component1.DoB();
            Debug.Log("Mediator включает component2 метод DoC");
            this._component2.DoC();
        }
    }
}
