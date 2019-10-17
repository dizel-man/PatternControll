using UnityEngine;

namespace state
{
    public class DrivingState : IState
    {
        private readonly Car _car;

        public DrivingState(Car car)
        {
            _car = car;
        }

        public void Drive()
        {
            TryDrive();
        }

        public void FillTank()
        {
            Debug.Log(" Driving - Нельзя заправляться на ходу");
        }

        public void Stop()
        {
            Debug.Log("Driving - Покатался? Ну постоим....");
            _car.SetState(_car.EngineStarted);
        }

        public void TurnKey()
        {
            Debug.Log("Driving - На ходу ключ не трогать");
        }

        private void TryDrive()
        {
            if (_car.Gasoline > 0)
            {
                Debug.Log("Поехали");
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

