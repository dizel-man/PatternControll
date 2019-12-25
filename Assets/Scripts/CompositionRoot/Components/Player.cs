using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IPlayer
{

    [SerializeField]
    private string namePref = "Man";

    public void Hello()
    {
        Debug.Log("Player say Hello!");
        Instantiate(Resources.Load(namePref) as GameObject);
    }

    public void GoodBye()
    {
        Debug.Log("Player say Goodbye!");
    }
}
