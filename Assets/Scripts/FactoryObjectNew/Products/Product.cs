using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Fac
{

    abstract class Product : ScriptableObject
    {
        public abstract GameObject GetObject(GameObject go);
    }

}

