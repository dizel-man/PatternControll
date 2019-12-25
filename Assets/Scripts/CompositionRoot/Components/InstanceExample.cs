using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceExample : MonoBehaviour, IInstance
{

    void Awake()
    {
        // Instantiate(GetGO());
       // StartCoroutine(GeneratorFromTime());
    }

    public GameObject GetGO()
    {        
        GameObject go = Resources.Load("Man") as GameObject;
        Debug.Log("AAA");
        return go;
    }

    IEnumerator GeneratorFromTime()
    {
        yield return new WaitForSeconds(5);
        Instantiate(GetGO());
    }
}
