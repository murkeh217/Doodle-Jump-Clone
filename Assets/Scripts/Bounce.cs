using UnityEngine;
public class Bounce : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //adds a force to the player on coming in contact with platform
        if(collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 600f);
        }
    }
}
