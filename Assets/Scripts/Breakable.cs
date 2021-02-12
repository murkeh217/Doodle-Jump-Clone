using UnityEngine;
using System.Collections;

public class Breakable : MonoBehaviour
{
    public GameObject player;

    public float someVal;
    private void Update()
    {
        if (player.transform.position.y < (Camera.main.transform.position.y - someVal))
        {
            player.SetActive(false);
        }

    }
    void OnCollisionEnter2D(Collision2D collision)
	{
		//destroy platform on collision with player
		if (collision.gameObject.name=="Player")
		{
			Destroy(gameObject);
		}
	}
}