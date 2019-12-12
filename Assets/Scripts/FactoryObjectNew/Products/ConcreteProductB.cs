using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fac
{
   
    class ConcreteProductB : Product
    {
        public override GameObject GetObject(GameObject go)
        {
            return Instantiate(go);
        }
    }

}
