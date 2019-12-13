using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceObg : MonoBehaviour
{

    public GameObject instObj;

    public void Instantiate()
    {
       
        GameObject g = Instantiate(instObj, transform.position, Quaternion.identity);
    }
}
