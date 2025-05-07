using UnityEngine;
using UnityEngine.SceneManagement;

public class MainGameManager : MonoBehaviour
{
    public void LoadMiniGameScene()
    {
        SceneManager.LoadScene("FlappyPlane");
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
