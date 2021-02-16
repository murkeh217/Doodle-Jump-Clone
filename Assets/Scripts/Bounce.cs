using System.Collections;
using UnityEngine;
public class Bounce : MonoBehaviour
{
    public float someVal;

    public GameObject platform;

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
        //adds a force to the player on coming in contact with platform
        if(collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 600f);
        }
    }
}
