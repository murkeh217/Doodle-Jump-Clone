using UnityEngine;
using System.Collections;

public class Breakable : MonoBehaviour
{
	Rigidbody2D rb2d;
	void Start()
	{
		rb2d = GetComponent<Rigidbody2D>();
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.name=="Player")
		{
			Destroy(gameObject);
		}
	}

	void DropPlatform()
	{
		rb2d.isKinematic = false;
	}
}