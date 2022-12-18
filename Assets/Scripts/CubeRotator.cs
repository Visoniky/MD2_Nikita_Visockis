using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotator : MonoBehaviour
{
    public Vector3 currentRot;

    void FixedUpdate()
    {
        currentRot = GetComponent<Transform> ().eulerAngles;

        if(Input.GetAxis ("Horizontal") > .2)
        {
            transform.Rotate(0, 0, -1);
        }

        if(Input.GetAxis ("Horizontal") < -.2)
        {
            transform.Rotate(0, 0, 1);
        }

        if(Input.GetAxis ("Vertical") > .2)
        {
            transform.Rotate(1, 0, 0);
        }
        if(Input.GetAxis ("Vertical") < -.2)
        {
            transform.Rotate(-1, 0, 0);
        }
    }
}

