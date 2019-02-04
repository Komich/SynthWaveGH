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
    float rotValue = 0f;

    void Move()
    {
        mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, zPosition));
        Vector3 curPos = Vector3.Lerp(transform.position, new Vector3(mousePos.x, yPosition, zPosition), moveSpeed * Time.deltaTime);
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
        if (rotValue == 0)
        {
            rotValue += Time.deltaTime;
        }
        else if (rotValue >= 1) rotValue -= Time.deltaTime;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 90), rotValue);
        print(rotValue);
    }
    void Update()
    {
        Move();
        Rotate();
    }
}
