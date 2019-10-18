using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunSinglton : MonoBehaviour
{
    Singleton singleton;
    void Start()
    {
        singleton = Singleton.getInstance();
    }

    
}
