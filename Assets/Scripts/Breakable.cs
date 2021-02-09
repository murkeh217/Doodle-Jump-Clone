using UnityEngine;
using System.Collections;

public class Breakable : MonoBehaviour
{
	void OnCollisionEnter2D(Collision2D collision)
	{
		//destroy platform on collision with player
		if (collision.gameObject.name=="Player")
		{
			Destroy(gameObject);
		}
	}
}