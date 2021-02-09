using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void startGame()
    {
        //just load game on click
        SceneManager.LoadScene("GameScene");
    }
}
