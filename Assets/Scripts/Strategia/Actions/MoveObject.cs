using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace strat
{
    [CreateAssetMenu(menuName = "Actions/Move Object Based on Input")]
    public class MoveObject : Action
    {
        public InputAxis horizontal;
        public InputAxis vertical;


        public override void Execute(object o)
        {
            if(o is ActionHook)
            {
                ActionHook a = (ActionHook)o;
                Transform t = a.mTransform;

                float h = horizontal.value;
                float v = vertical.value;
                float moveAmount = Mathf.Clamp01(Mathf.Abs(h) + Mathf.Abs(v)); 

                Vector3 moveDir = t.forward * moveAmount;

                t.position += moveDir * .04f;
            }
        }
    }

}
