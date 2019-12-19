using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace composite
{
    public class Circle : IShape
    {
        public override void Draw()
        {
            Debug.Log("Hello I am Circle");
        }
    }

}

