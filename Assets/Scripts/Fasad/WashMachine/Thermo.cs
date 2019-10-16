
using UnityEngine;


namespace fasad
{
    public class Thermo 
    {
        public int GetTemp()
        {
            return 50;
        }

       public void WarmUp(int degrees)
        {
            Debug.Log("нагреваю температура " + degrees);
        }
    }

}

