using UnityEngine;
using System.Collections;

public class Breakable : MonoBehaviour
{
    public GameObject player;

    public float someVal;
    private void Update()
    {
        if (gameObject.transform.position.y + someVal < Camera.main.transform.position.y)
        {
            StartCoroutine(Delay());
        }

    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1f);
        gameObject.SetActive(false);

    }
    void OnCollisionEnter2D(Collision2D collision)
	{
		//destroy platform on collision with player
		if (collision.gameObject.name=="Player")
		{
            gameObject.SetActive(false);
		}
	}
}