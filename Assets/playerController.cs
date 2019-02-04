using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public new Vector3 playerPos;
    public float yPosition = 0f;
    public float zPosition = 10f;
    public float moveSpeed;
    public Vector3 mousePos;

    void Move()
    {
        
    }

    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Vector3 curPos = Vector3.Lerp(transform.position,new Vector3(mousePos.x, yPosition, zPosition), moveSpeed * Time.deltaTime);
        //transform.position = curPos;

        if (transform.position.x > 6)
        {
            transform.position = new Vector3(6, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -6)
        {
            transform.position = new Vector3(-6, transform.position.y, transform.position.z);
        }
    }
}
