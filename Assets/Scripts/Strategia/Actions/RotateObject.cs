using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace strat
{
    [CreateAssetMenu(menuName = "Actions/Rotate Object Based on Input")]
    public class RotateObject : Action
    {
        public InputAxis horizontal;
        public InputAxis vertical;
        public TransformVarible cameraTransform;


        public override void Execute(object o)
        {

            if (cameraTransform.value == null)
                return;

            if (o is ActionHook)
            {
                ActionHook a = (ActionHook)o;
                Transform t = a.mTransform;

                float h = horizontal.value;
                float v = vertical.value;

                Vector3 rotateDir = cameraTransform.value.forward * v;
                rotateDir += t.right * h;


                if (rotateDir == Vector3.zero)
                    rotateDir = t.forward;

                Quaternion targetRot = Quaternion.LookRotation(rotateDir);
                Quaternion rotation = Quaternion.Slerp(t.rotation, targetRot, Time.deltaTime * 8f);
                t.rotation = rotation;
            }
        }
    }

}


