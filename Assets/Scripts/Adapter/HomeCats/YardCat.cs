//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;



namespace adapter
{
    public class YardCat : IHomeCat
    {
        public string Name { get; set; }

        public void Meow()
        {
            Debug.Log("мяу мяуууу");
        }

        public void Scratch()
        {
            Debug.Log("я  царапаюсь не сильно");
        }
    }
}




