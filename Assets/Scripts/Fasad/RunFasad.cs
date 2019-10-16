using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// фасад нужен для обобщения разрозненных классов и интерфейсов  в общий упращенный интерфейс
// по средствам композиции этих объектов

namespace fasad
{
    public class RunFasad : MonoBehaviour
    {

        WashManagingSubsystem water;
        Thermo thermo;
        Engine engine;
        Dryer dryer;

        void Start()
        {

            water = new WashManagingSubsystem();
            thermo = new Thermo();
            engine = new Engine();
            dryer = new Dryer();


            /*

            //хлопок
            water.FillWater(10);
            thermo.WarmUp(70);
            engine.Rotate();
            engine.Rotate();
            engine.Stop();
            water.EmptyWater();
            dryer.Dry(30, 100);

            //шерсть
            water.FillWater(50);
            thermo.WarmUp(70);
            engine.Rotate();
            engine.Rotate();
            engine.Rotate();
            engine.Stop();
            water.EmptyWater();
            engine.Rotate();
            engine.Rotate();
            engine.Stop();
            dryer.Dry(50, 550);
            
            */



            // и теперь упращенно:

            WashingMachine washingMachine = new WashingMachine(water, thermo, engine, dryer);

            //хлопок
            washingMachine.WashCotton();
            //шерсть
            washingMachine.WashWool();

            /*
            //не очень хорошее использование
            int temp = washingMachine.GetTermometr().GetTemp();
            */
            // так лучше
            int temp = washingMachine.GetTermometr();
        }

    }

}

