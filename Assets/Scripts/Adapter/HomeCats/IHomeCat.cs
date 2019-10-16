//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

namespace adapter
{

    interface IHomeCat
    {
        string Name { get; set; }
        void Meow();//мяуконие
        void Scratch();//царапание
    }
}

