using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Fac
{
    class ConcreteFactoryA : Factory
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

}
