using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace strat
{
    [CreateAssetMenu(menuName = "State")]
    public class State : ScriptableObject
    {
        public List<Action> actions = new List<Action>();


        public void Tick(object o)
        {
            for (int i = actions.Count - 1; i >= 0; i--)
            {
                actions[i].Execute(o);
            }
        }
    }

}

 