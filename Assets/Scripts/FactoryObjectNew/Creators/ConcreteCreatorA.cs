using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Fac
{
    class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

}
