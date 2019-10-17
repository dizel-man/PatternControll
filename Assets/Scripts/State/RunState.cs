using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//динамическое изменение состояний с помощью стейтов

namespace state
{
    public class RunState : MonoBehaviour
    {
        Car car;
       
        void Start()
        {
            //мы работаем только с объектом машины
            //и мы ничего не знаем какие состояния он использует
            car = new Car();

            //когда мы вызываем эти методы мы думаем, 
            //что мы работаем с одним и тем же объектом
            //на самом деле мы имеем дело с пятью различными объектами
            // car, drivingState, emptyState, startedState, fullState
            car.FillTank();
            car.TurnKey();
            car.TurnKey();
            car.TurnKey();
            car.Drive();
            car.Stop();
        }

       
       
    }

}
