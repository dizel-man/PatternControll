using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace strat
{
    public abstract class Action : ScriptableObject
    {
        public abstract void Execute(object o);   
    }

}

