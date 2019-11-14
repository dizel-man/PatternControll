using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunMediator : MonoBehaviour
{

    Component1 component1 = new Component1();
    Component2 component2 = new Component2();

    ConcreteMediator ConcreteMediator;
   

  

    void Start()
    {
        ConcreteMediator = new ConcreteMediator(component1, component2);

       // Debug.Log("Client triggets operation A.");
        component1.DoA();

        Debug.Log("__");

      //  Debug.Log("Client triggers operation D.");
        component2.DoD();

    }


    void Update()
    {
        
    }
}
