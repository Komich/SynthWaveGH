using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    new Vector3 playerPos;
    float yPosition = 0f;
    public float zPosition = 10f;
    public float moveSpeed;
    Vector3 mousePos;
    public float rotValue = 0f;
    Quaternion playerRotation;

    public class playerInfo
    {
         static public Vector3 playerPosStat;
    }

    void Move()
    {
        mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, zPosition));
        Vector3 curPos = Vector3.Lerp(transform.position, new Vector3(mousePos.x, yPosition, transform.position.z), moveSpeed * Time.deltaTime);
        transform.position = curPos;

        if (transform.position.x > 6)
        {
            transform.position = new Vector3(6, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -6)
        {
            transform.position = new Vector3(-6, transform.position.y, transform.position.z);
        }
    }
    void Rotate()
    {
        float rotAngle = mousePos.x * rotValue; 
        playerRotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, rotAngle), 1);
        transform.rotation = playerRotation;
    }
    void Update()
    {
        playerInfo.playerPosStat = transform.position;
        Move();
        Rotate();
    }
}
