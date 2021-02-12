using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlatformGenerator : MonoBehaviour
{
    public Text text;

    public GameObject player;
    public GameObject platformPrefab;
    public GameObject springPrefab;
    public GameObject movingHorizontalPrefab;
    public GameObject movingVerticalPrefab;
    public GameObject breakablePrefab;
    public GameObject platGen;


    //public GameObject platformPrefab;
    public List<GameObject> platform;
    int noOfPlatforms = 10;

    public float levelWidth = 5f;
    public float minY = .2f;
    public float maxY = 4f;
    static int counter;
    float xPos, yPos;

    public Camera mainCam;

    void Start()
    {
        mainCam = Camera.main; 
        //Platform generate wrt the camera
        counter = 0;
        for (int i = 0; i < noOfPlatforms; i++)
        {
            //putting all prefabs in an array so that they can be accessed randomly
            var prefabs = new[] { platformPrefab, springPrefab, movingHorizontalPrefab, movingVerticalPrefab, breakablePrefab };
            var index = Random.Range(0, prefabs.Length);
            xPos = Random.Range(-levelWidth, levelWidth);
            yPos = Random.Range(minY, maxY);
            Vector2 pos = new Vector2(xPos, yPos);
            var temp = Instantiate(prefabs[index],pos,Quaternion.identity);
            temp.SetActive(false);
            platform.Add(temp);
        }
    }

    private void Update()
    {
        platform[0].SetActive(false);
        platform[0].transform.position = new Vector3(Random.Range(-levelWidth, levelWidth), Random.Range(minY, maxY), 0);

        int numbers = Random.Range(1, 5);
        for (int i = 0; i <= numbers; i++)
        {
            Debug.Log(counter + "Counter in if condition");
            if (counter < noOfPlatforms)
            {
                GameObject plat = platform[i];
                if (!plat.activeInHierarchy)
                {
                    plat.transform.position = new Vector3(Random.Range(-levelWidth, levelWidth), Random.Range(minY, maxY), 0);
                    plat.SetActive(true);
                    counter++;
                }
            }
            else
            {
                Debug.Log(counter + "counter in else");

                counter = 0;
            }
        }

        /*To deactivate the older platforms*/
        for (int i = 0; i < noOfPlatforms; i++)
        {
            GameObject plat = platform[i];
            if (plat.activeInHierarchy && plat.transform.position.y < platform[0].transform.position.y - 10f)
            {
                plat.SetActive(true);
            }
        }
        Debug.Log(counter);

    }

    Vector3 GetNewPosition()
    {
        float xPos = Random.Range(-levelWidth, levelWidth);
        float zPos = 0f;
        float yPos = 0f;
        Debug.Log(counter + "counter in getnewpos");
        if (counter < 1)
        {
            yPos = Random.Range(minY, maxY) + platform[noOfPlatforms - 1].transform.position.y;
        }
        else
        {
            yPos = Random.Range(minY, maxY) + platform[counter - 1].transform.position.y;
        }
        Vector3 pos = new Vector3(xPos, yPos, zPos);
        return pos;
    }

/*

    //naive approach to infinte platform which generates platform on colliding and disables previous platforms

    void Spawn(GameObject go, GameObject prefab)
    {
        if (Random.Range(1, 9) == 1)
        {
            go.SetActive(false);
            Instantiate(prefab, new Vector2(Random.Range(-4.5f, 4.5f), player.transform.position.y + (9 + Random.Range(0.1f, 2.0f))), Quaternion.identity);
        }
        else
        {
             go.transform.position = new Vector2(Random.Range(-4.5f, 4.5f), player.transform.position.y + (9 + Random.Range(0.1f, 2.0f)));
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        string name = collision.gameObject.name;

        switch (name)
        {
            case "Platform":
                Spawn(collision.gameObject, platformPrefab);
                break;
            case "Spring":
                Spawn(collision.gameObject, springPrefab);
                break;
            case "MovingHorizontalPlatform":
                Spawn(collision.gameObject, movingHorizontalPrefab);
                break;
            case "MovingVerticalPlatform":
                Spawn(collision.gameObject, movingVerticalPrefab);
                break;
            case "BreakablePlatform":
                Spawn(collision.gameObject, breakablePrefab);
                break;
            default:
                new System.ArgumentException(nameof(collision));
                break;
        }
    }*/
}