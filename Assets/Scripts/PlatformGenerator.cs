using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformGenerator : MonoBehaviour
{ 
    public Text text;
    public GameObject player;
    public GameObject platformPrefab;
    public GameObject springPrefab;
    public GameObject myPlat;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name.StartsWith("Platform"))
        {
            
            if (Random.Range(1, 5) == 1)
            {
                //disabling instead of destroying objects so as to save memory
                collision.gameObject.SetActive(false);
                Instantiate(springPrefab, new Vector2(Random.Range(-4.5f, 4.5f), player.transform.position.y + (10 + Random.Range(0.1f, 1.0f))), Quaternion.identity);

            }
            else
            {

                collision.gameObject.transform.position = new Vector2(Random.Range(-4.5f, 4.5f), player.transform.position.y + (10 + Random.Range(0.1f, 1.0f)));

            }

        }
        else if (collision.gameObject.name.StartsWith("Spring"))
        {

            if (Random.Range(1, 5) == 1)
            {

                collision.gameObject.transform.position = new Vector2(Random.Range(-4.5f, 4.5f), player.transform.position.y + (10 + Random.Range(0.1f, 1.0f)));

            }
            else
            {

                collision.gameObject.SetActive(false);
                Instantiate(platformPrefab, new Vector2(Random.Range(-4.5f, 4.5f), player.transform.position.y + (10 + Random.Range(0.1f, 1.0f))), Quaternion.identity);


            }

        }
    }
    
}
