using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameExit : MonoBehaviour
{
    public string returnSceneName = "SampleScene"; // ���� ���� �� �̸�

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(returnSceneName);
        }
    }
}
