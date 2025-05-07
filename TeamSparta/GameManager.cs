using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; // 싱글톤!

    public UIManager uiManager;

    private int score = 0;
    private bool isGameOver = false;

    void Awake()
    {
        // 싱글톤 초기화
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
            uiManager.ResetScore(); // 점수 초기화
        }
        else
        {
            Debug.LogError("UIManager가 연결되지 않았습니다!");
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
