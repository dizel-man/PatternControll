using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Fac
{
    class ConcreteFactoryB : Factory
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }

}
