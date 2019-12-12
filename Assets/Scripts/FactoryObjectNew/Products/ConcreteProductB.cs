using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fac
{

    class ConcreteProductB : Product
    {
        public override void Make()
        {
            Debug.Log("make prod B");
        }
    }

}
