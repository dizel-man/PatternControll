using UnityEngine;

namespace ShablonniyMethod
{
     class HotDog : FastFood
    {
        
        public override void PrepareMainIngridient()
        {
            Debug.Log("Sous");
        }

        public override void AddTopings()
        {
            Debug.Log("Mustrad");
        }

    }
}



