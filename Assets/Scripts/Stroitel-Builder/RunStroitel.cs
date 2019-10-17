using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace stroitel
{
    public class RunStroitel : MonoBehaviour
    {
        CarBuilderBase vwBuilder = new VolkswagenBuilder();
        CarBuilderBase audiBuilder = new AudiBuilder();

        void Start()
        {
            /*
             
           // 1 variant - работает
           var car1= vwBuilder.GetCar();
           var car2= audiBuilder.GetCar();
           

            vwBuilder.BuildMultimedia();
            Debug.Log(car1.Multimedia);

            audiBuilder.BuildEngine();
            Debug.Log(car2.Engine);
            audiBuilder.BuildWheels();
            Debug.Log(car2.Wheel);

            */

            //не работает так как это не чистый c#
            Debug.Log("дешовый авто");
            CarFactoryBase constructor = new CheapCArFactory(new VolkswagenBuilder());
            var car = constructor.Construct();
            Debug.Log(car);


        }

       
    }
}


