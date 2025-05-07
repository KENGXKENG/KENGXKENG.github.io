using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameExit : MonoBehaviour
{
    public string returnSceneName = "SampleScene"; // 원래 게임 씬 이름

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(returnSceneName);
        }
    }
}
