using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunDependency : MonoBehaviour
{
    DependencyLogic logicOne;
    DependencyLogic logicTwo;

    void Start()
    {
        logicOne = new DependencyLogic(new ClassOne());
        Debug.Log("--");
        logicTwo = new DependencyLogic(new ClassTwo());
    }

   
}
