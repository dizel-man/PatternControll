//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

namespace adapter
{

    public class PedigreedCat : IHomeCat
    {
        public string Name { get; set ; }

        public void Meow()
        {
            Debug.Log("мяу");
        }

        public void Scratch()
        {
            Debug.Log("я не царапаюсь");
        }
    }

}

