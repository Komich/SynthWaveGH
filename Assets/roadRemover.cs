using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadRemover : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "RoadObstacle")
        {
            Destroy(other.gameObject, 5);
        }
    }
}
