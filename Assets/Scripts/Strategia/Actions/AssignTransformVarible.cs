using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace strat
{
    [CreateAssetMenu]
    public class AssignTransformVarible : Action
    {
        public TransformVarible targetTransform;

        public override void Execute(object o)
        {
           if(o is ActionHook)
            {
                ActionHook a = (ActionHook)o;
                targetTransform.value = a.mTransform;
                a.currentState = null;
            }
        }
    }
}


