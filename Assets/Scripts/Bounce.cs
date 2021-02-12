using UnityEngine;
public class Bounce : MonoBehaviour
{
    public float someVal;

    //public GameObject platform;

    public static Bounce Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }
    private void Update()
    {
        if (gameObject.transform.position.y + someVal <= Camera.main.transform.position.y)
        {
            gameObject.SetActive(false);
        }

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
