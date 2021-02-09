using UnityEngine;
public class CameraController : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    void Update()
    {
        // this will keep camera locked on player and only move along y axis
        Vector3 position = transform.position;
        position.y = (player.position + offset).y;
        //if (transform.position.y < player.position.y)
            transform.position = position;
    }
}