using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMove : MonoBehaviour
{
    float moveSpeed = 3f;
    bool moveUp = true;
    void Update()
    {


        if (transform.position.y > 2f)
            moveUp = false;
        if (transform.position.y < -2f)
            moveUp = true;

        if (moveUp)
            transform.position = new Vector2(transform.position.x, transform.position.y + moveSpeed * Time.deltaTime);
        else
            transform.position = new Vector2(transform.position.x, transform.position.y - moveSpeed * Time.deltaTime);
    }
}
