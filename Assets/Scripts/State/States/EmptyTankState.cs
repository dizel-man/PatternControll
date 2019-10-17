using UnityEngine;

namespace state
{


    public class EmptyTankState : IState
    {
        private readonly Car _car;

        public EmptyTankState(Car car)
        {
            _car = car;
        }

        public void Drive()
        {
            Debug.Log("EmptyTank - И как мы поедем без бензина?");
        }

        public void FillTank()
        {
            //_car.Gasoline = 70;
           
            Debug.Log(" EmptyTank -Теперь бак полный");
           _car.SetState( _car.FullTank);

        }

        public void Stop()
        {
            Debug.Log("EmptyTank - нет бензина - значит стоим");
        }

        public void TurnKey()
        {
            Debug.Log("EmptyTank - Без бензина не работаю");
        }
    }

}


