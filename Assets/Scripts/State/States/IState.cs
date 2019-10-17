using UnityEngine;

namespace state
{
    //обязательно публичные
    public interface IState
    {
        void FillTank();
        void TurnKey();
        void Drive();
        void Stop();
    }

}
