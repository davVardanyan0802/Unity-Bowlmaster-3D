using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public float standingThreshold = 3f;

    void Start()
    {

    }


    void Update()
    {

    }

    public bool IsStanding()
    {
        Vector3 rotationEuler = transform.rotation.eulerAngles;
        float tiltInX = Mathf.Abs(rotationEuler.x);
        float tiltInZ = Mathf.Abs(rotationEuler.z);

        if (tiltInX < standingThreshold && tiltInZ < standingThreshold)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}
