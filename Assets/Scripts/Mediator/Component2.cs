﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Конкретные Компоненты реализуют различную функциональность. Они не
// зависят от других компонентов. Они также не зависят от каких-либо
// конкретных классов посредников.


//Компоненты — это разнородные объекты, содержащие бизнес-логику программы. 
//Каждый компонент хранит ссылку на объект посредника, но работает с ним только через абстрактный интерфейс посредников. 
//Благодаря этому, компоненты можно повторно использовать в другой программе, связав их с посредником другого типа.
//Компоненты не должны общаться друг с другом напрямую. Если в компоненте происходит важное событие, он должен оповестить 
//своего посредника, а тот сам решит — касается ли событие других компонентов, и стоит ли их оповещать.
//При этом компонент-отправитель не знает, кто обработает его запрос, а компонент-получатель не знает, кто его прислал.

public class Component2 : BaseComponent
{
    public void DoC()
    {
        Debug.Log("Component 2 запустил метод DoC.");

        this._mediator.Notify(this, "C");

    }

    public void DoD()
    {
        Debug.Log("Component 2 запустил метод DoВ.");

        this._mediator.Notify(this, "D");
    }
}
