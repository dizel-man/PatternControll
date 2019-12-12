using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Fac
{
    
    class ConcreteProductA : Product
    {
   
        public override GameObject GetObject(GameObject go)
        {
            return Instantiate(go);
        }


    }

}
