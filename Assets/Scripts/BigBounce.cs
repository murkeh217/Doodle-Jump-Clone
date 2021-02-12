using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBounce : MonoBehaviour
{
    public float someVal;

    public GameObject player;

    public static BigBounce Instance;
    private void Awake()
    {
        Instance = this;
    }
    private void Update()
    {
        if (player.transform.position.y < (Camera.main.transform.position.y - someVal))
        {
            player.SetActive(false);
        }
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
