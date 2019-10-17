using UnityEngine;
namespace state
{
    public class Car
    {
        public int Gasoline { get; set; }

        //это эдентично enum перечислению
        public EmptyTankState EmptyTank { get; private set; }
        public FullTankState FullTank { get; private set; }
        public EngineStartedState EngineStarted { get; private set; }
        public DrivingState Driving { get; private set; }
        private IState _currentState;

        public Car()
        {
            EmptyTank = new EmptyTankState(this);
            FullTank = new FullTankState(this);
            EngineStarted = new EngineStartedState(this);
            Driving = new DrivingState(this);

            _currentState = EmptyTank; //это начальное состояние
            Gasoline = 0;
        }
        // переключение состояний из разных стейтов
       public void SetState(IState state)
        {
            _currentState = state;
        }
        public void FillTank()
        {
            Gasoline = 70;
            _currentState.FillTank();
            //switch (_state)
            //{
            //    case CarState.EmptyTank:
            //        _state = CarState.FullTank;
            //        Debug.Log(" EmptyTank -Теперь бак полный");
            //        break;
      
        }

        public void TurnKey()
        {
            _currentState.TurnKey();
           
        }

        public void Drive()
        {
            _currentState.Drive();
            Gasoline -= 10;
         
        }

        public void Stop()
        {
            _currentState.Stop();
        }
    }
}
