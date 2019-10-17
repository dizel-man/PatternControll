
using UnityEngine;

namespace state
{
    public class EngineStartedState : IState
    {
        private readonly Car _car;

        public EngineStartedState(Car car)
        {
            _car = car;
        }

        public void Drive()
        {
            TryDrive();
        }

        public void FillTank()
        {
            Debug.Log(" EngineStarted -Нельзя заправиться с работающим двигателем");
        }

        public void Stop()
        {
            Debug.Log("EngineStarted - Я и так стою");
        }

        public void TurnKey()
        {
            Debug.Log("EngineStarted - Тсссю Передышка - Надо заглушить");
            _car.SetState(_car.FullTank);
        }

        private void TryDrive()
        {
            if (_car.Gasoline > 0)
            {
                Debug.Log("Поехали");
                _car.SetState(_car.Driving);
              //  _car.Gasoline -= 10;
            }
            else
            {
                Debug.Log("Бензин кончился");
                _car.SetState(_car.EmptyTank);

            }
        }
    }

}

