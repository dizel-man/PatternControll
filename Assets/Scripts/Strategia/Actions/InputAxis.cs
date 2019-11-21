using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace strat
{
    [CreateAssetMenu(menuName = "Actions/Input/Axis")]
    public class InputAxis : Action
    {
        public string targetInputName;
        public float value;

        public override void Execute(object o)
        {
            value = Input.GetAxis(targetInputName);
        }
    }

}
