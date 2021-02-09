using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController: MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("GameScene");
    }
}
