using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace strat
{

    public class ActionHook : MonoBehaviour
    {

       
        public State currentState;

       public Transform mTransform;

        private void Start()
        {
            mTransform = this.transform;
        }

        void Update()
        {
            if(currentState != null)
            currentState.Tick(this);

        }
    }

}
