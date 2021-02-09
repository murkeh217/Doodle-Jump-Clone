using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public Text startText;

    //to make player die on touching this collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            Debug.Log("Death triggered");
            startText.gameObject.SetActive(true);
            startText.text = "Game Over!";
            SceneManager.LoadScene(0);
        }
    }
}
