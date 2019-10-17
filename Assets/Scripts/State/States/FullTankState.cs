
using UnityEngine;


namespace state
{
    public class FullTankState : IState
    {
        private readonly Car _car;

        public FullTankState(Car car)
        {
            _car = car;
        }

        public void Drive()
        {
            Debug.Log("FullTank - Сначала заведи машину");
        }

        public void FillTank()
        {
            Debug.Log("FullTank - В меня столько не влезет");
        }

        public void Stop()
        {
            Debug.Log("FullTank - Я и так стою");
        }

        //поворот ключа
        public void TurnKey()
        {
           
            // и если машина старая то:
            int rmd = Random.Range(0,2);

            if(rmd != 1)
            {
                Debug.Log("FullTank - Дрыынннн дрын");
                _car.SetState(_car.EngineStarted);
            }
           
        }
    }

}

