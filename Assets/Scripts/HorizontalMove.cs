using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMove: MonoBehaviour
{
	float moveSpeed = 3f;
	bool moveRight = true;

	public float speed;

    void Update()
    {
		//to move platform right to left
				if (transform.position.x > 4f)
					moveRight = false;
				if (transform.position.x < -4f)
					moveRight = true;

				if (moveRight)
					transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
				else
					transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
			
	}
}