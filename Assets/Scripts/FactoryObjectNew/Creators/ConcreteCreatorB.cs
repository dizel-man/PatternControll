﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Fac
{
    class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }

}
