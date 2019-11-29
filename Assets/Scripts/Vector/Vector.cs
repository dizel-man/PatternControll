using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector : MonoBehaviour
{
    public float speed;
    public float Rspeed;
    public GameObject target;
    public float angle;//просто угол
    [Space(10)]
    public float dot;//угол больше или меньше 90 грю
    public bool more90gr;// больше 90 градусов
    [Space(10)]
    public float cross;// по часовой или против часовой
    public bool clockwise;//по часовой


    void Start()
    {
        
    }

    
    void Update()
    {
        float tr = Input.GetAxis("Vertical") * speed;
        float rt = Input.GetAxis("Horizontal") * Rspeed;

        tr *= Time.deltaTime;
        rt *= Time.deltaTime;

        transform.Translate(0, tr, 0);
        transform.Rotate(0, 0, -rt);

        angle = anglll();

        dot = dooot();
        more90gr = true;
        if (dot > 0)
        {
            more90gr = false;
        }

        cross = cros();
        clockwise = true;
        if (cross > 0)
        {
            clockwise = false;
        }

        Debug.DrawRay(transform.position, transform.up * 3, Color.red);
        Debug.DrawRay(target.transform.position, target.transform.up * 3, Color.green);

    }

    public float anglll()
    {
        float x = Vector2.Angle(transform.up, target.transform.position);
             return x;
    }

    public float dooot()
    {
        float x = Vector2.Dot(transform.up, target.transform.up);
        return x;
    }

    public float cros()
    {
        Vector3 x = Vector3.Cross(transform.up, target.transform.up);
        return x.z;
    }

}
