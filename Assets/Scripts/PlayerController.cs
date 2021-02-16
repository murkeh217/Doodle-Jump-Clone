using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class PlayerController : MonoBehaviour
{

private Rigidbody2D rb2d;

    private float topScore = 0.0f;

    public Text scoreText;
    public Text startText;

    public float dirX;
    public float playerMoveSpeed = 30f;

    float leftConstraint = Screen.width;
    float rightConstraint = Screen.width;
    float buffer = 1.0f;
    Camera cam;
    float distanceZ;

    private float moveInput;
    private float speed = 10f;
  
    void Start()
    {

        rb2d = GetComponent<Rigidbody2D>();

        rb2d.gravityScale = 0;
        rb2d.velocity = Vector3.zero;


        cam = Camera.main;
        distanceZ = Mathf.Abs(cam.transform.position.z + transform.position.z);

        leftConstraint = cam.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, distanceZ)).x;
        rightConstraint = cam.ScreenToWorldPoint(new Vector3(Screen.width, 0.0f, distanceZ)).x;

    }

     void Update()
    {
        startText.gameObject.SetActive(false);
        rb2d.gravityScale = 5f;

        //movement and animation handling of player
        dirX = Input.acceleration.x * playerMoveSpeed;
        transform.Translate(new Vector2(dirX, 0f) * Time.deltaTime);


        if (dirX < 0 || moveInput < 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = false;


        }
        else if(dirX > 0 || moveInput > 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = true;

        }

        if (rb2d.velocity.y > 0 && transform.position.y > topScore)
        {
            topScore = transform.position.y;
        }

        scoreText.text = "Score: " + Mathf.Round(topScore).ToString();

    }


    void FixedUpdate()
    {
        rb2d.velocity = new Vector2(dirX, rb2d.velocity.y);

        moveInput = Input.GetAxis("Horizontal");

        rb2d.velocity = new Vector2(moveInput * speed, rb2d.velocity.y);

        float x = Input.acceleration.x; //Accelerometer input from user's device
        transform.Translate(x, 0f, 0f); //Using only x value to make it move left/right

        if (this.transform.position.x < leftConstraint - buffer)
        { //If position of character is outside the left frame
            this.transform.position = new Vector2(rightConstraint + buffer, this.transform.position.y); //Spawn it near the right frame of the screen
        }
        else if (this.transform.position.x > rightConstraint + buffer)
        {
            this.transform.position = new Vector2(leftConstraint - buffer, this.transform.position.y);
        }
    }

}
