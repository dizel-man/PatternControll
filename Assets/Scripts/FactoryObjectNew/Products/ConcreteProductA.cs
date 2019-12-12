using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Fac
{

    class ConcreteProductA : Product
    {
        public override void Make()
        {
            Debug.Log("make prod A");
        }
    }

}
