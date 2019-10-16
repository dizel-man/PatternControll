using UnityEngine;

namespace ShablonniyMethod
{

    class Hamburger: FastFood
    {

        public override void PrepareMainIngridient()
        {
            Debug.Log("Meat");
        }

        public override void AddTopings()
        {
            Debug.Log("Ketchup");
        }

  
    }

}
