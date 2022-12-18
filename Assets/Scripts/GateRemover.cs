using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateRemover : MonoBehaviour
{
public GameObject Key;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Destroy(Key, 1f);
        }
    }
}
