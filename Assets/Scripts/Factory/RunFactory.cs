using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Factory
{

    public class RunFactory : MonoBehaviour
    {

        VolswagenFacility RussianFacility;
        VolswagenFacility DeuschFacility;

        void Start()
        {

            RussianFacility = new RussianVolswagenFacility();
            DeuschFacility = new DeuschVolswagenFacility();

            RussianFacility.GetCar("Golf");

            DeuschFacility.GetCar("Tiguan");
        }


    }

}
