using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; // �̱���!

    public UIManager uiManager;

    private int score = 0;
    private bool isGameOver = false;

    void Awake()
    {
        // �̱��� �ʱ�ȭ
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        score = 0;
        isGameOver = false;

        if (uiManager != null)
        {
            uiManager.ResetScore(); // ���� �ʱ�ȭ
        }
        else
        {
            Debug.LogError("UIManager�� ������� �ʾҽ��ϴ�!");
        }
    }

    public void AddScore()
    {
        if (isGameOver) return;

        score++;
        uiManager.AddScore(1);
    }

    public void GameOver()
    {
        isGameOver = true;
        uiManager.SetRestart();
        Debug.Log("Game Over");
    }

    public void RestartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("FlappyPlane");
    }
}
