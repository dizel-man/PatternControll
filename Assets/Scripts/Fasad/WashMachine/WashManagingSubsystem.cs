using UnityEngine;

namespace fasad
{
    public class WashManagingSubsystem
    {
        public void FillWater(int liters)
        {
            Debug.Log("залито воды" + liters);
        }
        public void EmptyWater()
        {
            Debug.Log("вода слита");
        }
    }

}

