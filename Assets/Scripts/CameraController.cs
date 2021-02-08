using UnityEngine;
using System.Collections;
public class CameraController : MonoBehaviour
{
    [SerializeField]
    GameObject player;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // this will keep camera locked on player and only move along y axis
        transform.position = new Vector3(transform.position.x, GameObject.Find("Player").transform.position.y, transform.position.z) ;
    }
}