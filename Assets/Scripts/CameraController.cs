using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;

    void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
    void Update()
    {
        if (player != null)
        {
            if (player.position.y > transform.position.y)
            {//If y position of characerter is more than of camera's then, move the camera to character's position
                transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
            }
        }
    }
}