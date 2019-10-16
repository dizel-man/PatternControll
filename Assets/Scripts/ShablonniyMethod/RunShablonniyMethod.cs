using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShablonniyMethod
{

    public class RunShablonniyMethod : MonoBehaviour
    {
       
        void Start()
        {
            FastFood hamburger = new Hamburger();
            FastFood hotDog = new HotDog();

            hamburger.Prepare();
            hotDog.Prepare();
        }

       
    }
}


