using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DependencyLogic
{
    private Iinterface _inter;

    public DependencyLogic(Iinterface inter)
    {
        this._inter = inter;
        _inter.Execute();

    }
}
