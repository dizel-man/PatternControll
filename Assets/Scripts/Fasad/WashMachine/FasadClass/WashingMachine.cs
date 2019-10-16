//превращаем разрозненное в один

//сам ничего не делает, он просто
// распределяем обязанности у разных разрозненных классов

namespace fasad
{
    public class WashingMachine
    {
        WashManagingSubsystem _water;
        Thermo _thermo;
        Engine _engine;
        Dryer _dryer;

        public WashingMachine(WashManagingSubsystem water, Thermo thermo, Engine engine, Dryer dryer)
        {
            _water = water;
            _thermo = thermo;
            _engine = engine;
            _dryer = dryer;
        }

        //хлопок
        public void WashCotton()
        {
            _water.FillWater(10);
            _thermo.WarmUp(70);
            _engine.Rotate();
            _engine.Rotate();
            _engine.Stop();
            _water.EmptyWater();
            _dryer.Dry(30, 100);
        }
        //шерсть
        public void WashWool()
        {
            _water.FillWater(50);
            _thermo.WarmUp(70);
            _engine.Rotate();
            _engine.Rotate();
            _engine.Rotate();
            _engine.Stop();
            _water.EmptyWater();
            _engine.Rotate();
            _engine.Rotate();
            _engine.Stop();
            _dryer.Dry(50, 550);
        }

        /*
        //не очень хорошо
        public Thermo GetTermometr()
        {
            return _thermo;

        }
        */

        // так лучше
        public int GetTermometr()
        {
            return _thermo.GetTemp();
        }
    }

}

