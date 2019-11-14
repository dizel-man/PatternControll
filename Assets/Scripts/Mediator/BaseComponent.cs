using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Базовый Компонент обеспечивает базовую функциональность хранения
// экземпляра посредника внутри объектов компонентов.

public class BaseComponent
{
    protected Imediator _mediator;

    public BaseComponent(Imediator mediator = null)
    {
        this._mediator = mediator;
    }

    public void SetMediator(Imediator mediator)
    {
        this._mediator = mediator;
    }
}
