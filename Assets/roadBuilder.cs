using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadBuilder : MonoBehaviour
{
    public Transform road;
    public Vector3 worldPos;
    public float spawnPoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if ((transform.position.z - playerController.playerInfo.playerPosStat.z) <= 325)
        {
            Instantiate(road, transform.position, Quaternion.identity);
            Destroy(this);
        }
    }
}
