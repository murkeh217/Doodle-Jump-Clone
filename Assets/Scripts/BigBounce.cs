using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBounce : MonoBehaviour
{
    public float someVal;

    public GameObject player;

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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //this bounce is bit greater than normal bounce
        if (collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {

            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 1000f);

        }

    }
}
