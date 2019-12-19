using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace composite
{
    public class Square : IShape
    {
        public override void Draw()
        {
            Debug.Log("Hello I am Square");
        }
    }

}

