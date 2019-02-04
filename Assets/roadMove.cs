using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadMove : MonoBehaviour
{
    public float speed;
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed);
    }
}
