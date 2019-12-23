using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IPlayer
{
  
    public void Hello()
    {
        Debug.Log("Player say Hello!");
    }

    public void GoodBye()
    {
        Debug.Log("Player say Goodbye!");
    }



}
