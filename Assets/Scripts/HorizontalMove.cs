using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMove: MonoBehaviour
{
	public float moveSpeed = 3f;
	bool moveRight = true;
	public float someVal;
	public GameObject player;
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

		if (player.transform.position.y < (Camera.main.transform.position.y - someVal))
		{
			player.SetActive(false);
		}

	}
}